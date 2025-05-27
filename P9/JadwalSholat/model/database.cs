using System.Data;
using MySql.Data.MySqlClient;

namespace JadwalSholat.Model
{
    internal class Database
    {
        private readonly string connectionString = "Server=localhost;Database=jadwal;Uid=root;Pwd=;";
        public MySqlConnection GetConnection() => new MySqlConnection(connectionString);
    }
}
