using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JadwalSholat.Models
{
    using JadwalSholat.Config;
    public class NoteModel
    {
        public int No { get; set; }
        public DateTime Tgl { get; set; }
        public string Catatan { get; set; }
    }
}
