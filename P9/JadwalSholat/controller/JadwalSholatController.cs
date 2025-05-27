using System;
using JadwalSholat.Model;

namespace JadwalSholat.Controller
{
    internal class JadwalSholatController
    {
        private readonly JadwalSholatModel model = new JadwalSholatModel();

        public (string Subuh, string Dzuhur, string Ashar, string Maghrib, string Isya)? Ambil(DateTime tgl)
        {
            return model.GetByDate(tgl);
        }
    }
}
