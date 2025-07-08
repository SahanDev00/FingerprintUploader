using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerprintUploader.Models
{
    public class FingerprintRecord
    {
        public string BiometricID { get; set; }
        public DateTime Timestamp { get; set; }
    }

    public class RealandLogEntry
    {
        public string UserId { get; set; }
        public string Time { get; set; }
    }
}
