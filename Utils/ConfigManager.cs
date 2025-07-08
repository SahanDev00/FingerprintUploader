using System.IO;
using System.Text.Json;
using FingerprintUploader.Models;

namespace FingerprintUploader.Utils
{
    public static class ConfigManager
    {
        private static readonly string ConfigPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\config\temp.json");


        public static void SaveConfig(Config config)
        {
            var json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(ConfigPath, json);
        }

        public static Config LoadConfig()
        {
            if (!File.Exists(ConfigPath)) return new Config();
            var json = File.ReadAllText(ConfigPath);
            return JsonSerializer.Deserialize<Config>(json);
        }
    }
}
