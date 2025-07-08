using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerprintUploader.Models
{
    // Models/Config.cs
    public class Config
    {
        public DatabaseConfig Database { get; set; }
        public ScannerConfig Scanner { get; set; }
    }

    public class DatabaseConfig
    {
        public string Host { get; set; }
        public string Port { get; set; }
        public string DBName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class ScannerConfig
    {
        public string IPAddress { get; set; }
        public string Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Model { get; set; }
    }

}
