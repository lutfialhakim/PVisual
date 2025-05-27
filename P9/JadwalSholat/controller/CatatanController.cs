using System;
using System.Data;
using JadwalSholat.Model;

namespace JadwalSholat.Controller
{
    internal class CatatanController
    {
        private readonly CatatanModel model = new CatatanModel();

        public DataTable TampilkanSemua() => model.GetAll();

        public void Tambah(DateTime tgl, string catatan) => model.Insert(tgl, catatan);

        public void Ubah(int no, DateTime tgl, string catatan) => model.Update(no, tgl, catatan);

        public void Hapus(int no) => model.Delete(no);
    }
}
