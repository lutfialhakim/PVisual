using System;
using MySql.Data.MySqlClient;

namespace JadwalSholat.Model
{
    internal class JadwalSholatModel
    {
        private readonly Database db = new Database();

        public (string Subuh, string Dzuhur, string Ashar, string Maghrib, string Isya)? GetByDate(DateTime tgl)
        {
            using var con = db.GetConnection();
            con.Open();
            var cmd = new MySqlCommand("SELECT * FROM jadwal_sholat WHERE tgl = @tgl", con);
            cmd.Parameters.AddWithValue("@tgl", tgl);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return (
                    reader["subuh"].ToString(),
                    reader["dzuhur"].ToString(),
                    reader["ashar"].ToString(),
                    reader["maghrib"].ToString(),
                    reader["isya"].ToString()
                );
            }
            return null;
        }
    }
}
