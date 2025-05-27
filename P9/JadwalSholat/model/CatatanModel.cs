using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace JadwalSholat.Model
{
    internal class CatatanModel
    {
        private readonly Database db = new Database();

        public DataTable GetAll()
        {
            using var con = db.GetConnection();
            string query = "SELECT * FROM catatan";
            var adapter = new MySqlDataAdapter(query, con);
            var data = new DataSet();
            adapter.Fill(data);
            return data.Tables[0];
        }

        public void Insert(DateTime tgl, string catatan)
        {
            using var con = db.GetConnection();
            con.Open();
            var cmd = new MySqlCommand("INSERT INTO catatan (tgl, catatan) VALUES (@tgl, @catatan)", con);
            cmd.Parameters.AddWithValue("@tgl", tgl);
            cmd.Parameters.AddWithValue("@catatan", catatan);
            cmd.ExecuteNonQuery();
        }

        public void Update(int no, DateTime tgl, string catatan)
        {
            using var con = db.GetConnection();
            con.Open();
            var cmd = new MySqlCommand("UPDATE catatan SET tgl = @tgl, catatan = @catatan WHERE No = @no", con);
            cmd.Parameters.AddWithValue("@no", no);
            cmd.Parameters.AddWithValue("@tgl", tgl);
            cmd.Parameters.AddWithValue("@catatan", catatan);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int no)
        {
            using var con = db.GetConnection();
            con.Open();
            var cmd = new MySqlCommand("DELETE FROM catatan WHERE No = @no", con);
            cmd.Parameters.AddWithValue("@no", no);
            cmd.ExecuteNonQuery();
        }
    }
}
