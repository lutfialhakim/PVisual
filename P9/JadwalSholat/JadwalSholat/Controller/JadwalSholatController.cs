using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;

namespace JadwalSholat.Controllers
{
    public class JadwalSholatController
    {
        private readonly MySqlConnection connection;

        public JadwalSholatController(string connectionString)
        {
            connection = new MySqlConnection(connectionString);
        }

        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM jadwal_sholat";
            MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
            da.Fill(dt);
            return dt;
        }
    }
}

