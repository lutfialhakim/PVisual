using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JadwalSholat.Models
{
    public class JadwalSholatModel
    {
        public int Id { get; set; }
        public DateTime Tgl { get; set; }
        public TimeSpan Subuh { get; set; }
        public TimeSpan Dzuhur { get; set; }
        public TimeSpan Ashar { get; set; }
        public TimeSpan Maghrib { get; set; }
        public TimeSpan Isya { get; set; }
    }
}
