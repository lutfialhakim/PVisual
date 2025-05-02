using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace JadwalSholatApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Koneksi database
        string connectionString = "Server=localhost; Database=jadwalsholat; Uid=root; Pwd=;";

        // Method untuk menampilkan jadwal sholat
        private void ShowPrayerTimes()
        {
            // Tanggal saat ini
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("yyyy-MM-dd");

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM jadwal WHERE tanggal = @tanggal";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@tanggal", formattedDate);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Ambil data dari database dan tampilkan di label yang sesuai
                        //lblImsak.Text = "Imsak: " + reader["imsak"].ToString();
                        lblSubuh.Text = "Subuh: " + reader["subuh"].ToString();
                        lblDzuhur.Text = "Dzuhur: " + reader["dzuhur"].ToString();
                        lblAshar.Text = "Ashar: " + reader["ashar"].ToString();
                        lblMaghrib.Text = "Maghrib: " + reader["maghrib"].ToString();
                        lblIsya.Text = "Isya: " + reader["isya"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan untuk tanggal " + formattedDate);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }

        // Event ketika form pertama kali dimuat
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowPrayerTimes();
        }
    }
}
