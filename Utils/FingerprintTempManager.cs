using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using FingerprintUploader.Models;

public static class FingerprintTempManager
{
    private static string TempFile => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config", "temp_fingerprints.json");

    public static void Save(List<FingerprintRecord> records)
    {
        string json = JsonSerializer.Serialize(records);
        File.WriteAllText(TempFile, json);
    }

    public static List<FingerprintRecord> Load()
    {
        if (!File.Exists(TempFile)) return new List<FingerprintRecord>();
        string json = File.ReadAllText(TempFile);
        return JsonSerializer.Deserialize<List<FingerprintRecord>>(json);
    }

    public static void Clear()
    {
        if (File.Exists(TempFile)) File.Delete(TempFile);
    }
}
