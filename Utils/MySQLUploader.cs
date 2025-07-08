using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using FingerprintUploader.Models;

namespace FingerprintUploader.Utils
{
    public class MySQLUploader
    {
        private readonly Config _config;

        public MySQLUploader()
        {
            _config = ConfigManager.LoadConfig();
            if (_config.Database == null)
                throw new Exception("Database config not found.");
        }

        public void Upload(List<FingerprintRecord> records)
        {
            string connStr = $"server={_config.Database.Host};port={_config.Database.Port};database={_config.Database.DBName};uid={_config.Database.Username};pwd={_config.Database.Password};";
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();

                var grouped = new Dictionary<string, List<DateTime>>();
                foreach (var record in records)
                {
                    if (!grouped.ContainsKey(record.BiometricID))
                        grouped[record.BiometricID] = new List<DateTime>();

                    grouped[record.BiometricID].Add(record.Timestamp);
                }

                foreach (var entry in grouped)
                {
                    var biometricID = entry.Key;
                    var timestamps = entry.Value;
                    timestamps.Sort();

                    DateTime? intime = timestamps[0];
                    DateTime? outtime = timestamps.Count > 1 ? timestamps[^1] : (DateTime?)null;

                    string query = "INSERT INTO fingerprint_records (Intime, Outtime, BiometricID) VALUES (@in, @out, @id)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@in", intime);
                        cmd.Parameters.AddWithValue("@out", (object?)outtime ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@id", biometricID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
