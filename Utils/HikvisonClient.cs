// HikvisionClient.cs
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Xml;
using FingerprintUploader.Models;
using FingerprintUploader.Utils;
using zkemkeeper;

public class HikvisionClient
{
    private readonly Config _config;

    public HikvisionClient()
    {
        _config = ConfigManager.LoadConfig();
        if (_config == null) throw new Exception("Config not found.");
        var scannerConfig = _config.Scanner;
        if (scannerConfig == null) throw new Exception("Scanner config not found.");
    }

    public List<FingerprintRecord> DownloadLogs()
    {
        switch (_config.Scanner.Model)
        {
            case "Hikvision":
                return GetLogsISAPI(); 
            case "Realand":
                return GetLogsISAPIRealand();
            default:
                return GetLogsISAPI();
        }
    }

    private List<FingerprintRecord> GetLogsISAPI()
    {
        var records = new List<FingerprintRecord>();
        string ip = _config.Scanner.IPAddress;
        string Port = _config.Scanner.Port;
        string username = _config.Scanner.UserName;
        string password = _config.Scanner.Password;

        string url = $"http://{ip}:{Port}/ISAPI/AccessControl/AccessLog";

        HttpClientHandler handler = new HttpClientHandler
        {
            Credentials = new NetworkCredential(username, password)
        };

        using (HttpClient client = new HttpClient(handler))
        {
            string xmlBody = $@"<AccessLogSearchDescription>
                <searchID>1</searchID>
                <maxResults>3000</maxResults>
                <searchResultPosition>0</searchResultPosition>
                <TimeSpan>
                    <startTime>{DateTime.Now.Date:yyyy-MM-ddTHH:mm:ss}</startTime>
                    <endTime>{DateTime.Now:yyyy-MM-ddTHH:mm:ss}</endTime>
                </TimeSpan>
            </AccessLogSearchDescription>";

            var content = new StringContent(xmlBody, Encoding.UTF8, "application/xml");
            var response = client.PostAsync(url, content).Result;

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Failed to fetch logs: {response.StatusCode}");

            string resultXml = response.Content.ReadAsStringAsync().Result;

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(resultXml);
            XmlNodeList logList = doc.SelectNodes("//AccessControlLog");

            foreach (XmlNode log in logList)
            {
                string biometricID = log["employeeNo"]?.InnerText;
                string time = log["time"]?.InnerText;

                if (!string.IsNullOrEmpty(biometricID) && !string.IsNullOrEmpty(time))
                {
                    records.Add(new FingerprintRecord
                    {
                        BiometricID = biometricID,
                        Timestamp = DateTime.Parse(time)
                    });
                }
            }
        }

        return records;
    }

    private List<FingerprintRecord> GetLogsISAPIRealand()
    {
        var records = new List<FingerprintRecord>();
        var zkem = new CZKEM();

        string ip = _config.Scanner.IPAddress;
        int port = int.Parse(_config.Scanner.Port);
        int machineNumber = 1; // Usually 1 by default

        bool connected = zkem.Connect_Net("192.168.1.155", 5500);
        if (!connected)
        {
            throw new Exception("Failed to connect to Realand device.");
        }

        if (!zkem.ReadGeneralLogData(machineNumber))
        {
            throw new Exception("Failed to read log data.");
        }

        int enrollNumber = 0, verifyMode = 0, inOutMode = 0, year = 0, month = 0,
            day = 0, hour = 0, minute = 0, second = 0, workCode = 0;

        while (zkem.SSR_GetGeneralLogData(machineNumber, out string userId, out verifyMode, out inOutMode,
            out year, out month, out day, out hour, out minute, out second, ref workCode))
        {
            var timestamp = new DateTime(year, month, day, hour, minute, second);

            records.Add(new FingerprintRecord
            {
                BiometricID = userId,
                Timestamp = timestamp
            });
        }

        zkem.Disconnect();

        return records;
    }

}
