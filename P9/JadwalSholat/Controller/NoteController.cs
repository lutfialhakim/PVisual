using System;
using System.Data;
using JadwalSholat.Config;

namespace JadwalSholat.Controllers
{
    public class NoteController
    {
        private koneksi db = new koneksi();

        public DataTable GetAllNotes()
        {
            string query = "SELECT * FROM catatan ORDER BY tgl DESC";
            return db.ShowData(query);
        }

        public void AddNote(DateTime tgl, string catatan)
        {
            db.InsertNote(tgl, catatan);
        }

        public void UpdateNote(int no, DateTime tgl, string catatan)
        {
            db.UpdateNote(no, tgl, catatan);
        }

        public void DeleteNote(int no)
        {
            db.DeleteNote(no);
        }
    }
}
