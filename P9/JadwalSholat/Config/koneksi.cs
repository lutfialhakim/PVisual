using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace JadwalSholat.Config
{
    public class koneksi
    {
        private string connectionstring = "Server=localhost;Database=jadwal;Uid=root;Pwd=;";
        private MySqlConnection kon;

        public void OpenConnection()
        {
            kon = new MySqlConnection(connectionstring);
            kon.Open();
        }

        public void CloseConnection()
        {
            if (kon != null && kon.State == ConnectionState.Open)
            {
                kon.Close();
            }
        }

        public void UpdateNote(int no, DateTime tgl, string catatan)
        {
            string query = "UPDATE catatan SET tgl = @tgl, catatan = @catatan WHERE no = @no";
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand(query, kon);
                command.Parameters.AddWithValue("@no", no);
                command.Parameters.AddWithValue("@tgl", tgl);
                command.Parameters.AddWithValue("@catatan", catatan);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memperbarui data: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void DeleteNote(int no)
        {
            string query = "DELETE FROM catatan WHERE no = @no";
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand(query, kon);
                command.Parameters.AddWithValue("@no", no);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menghapus data: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void InsertNote(DateTime tgl, string catatan)
        {
            string query = "INSERT INTO catatan (tgl, catatan) VALUES (@tgl, @catatan)";
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand(query, kon);
                command.Parameters.AddWithValue("@tgl", tgl);
                command.Parameters.AddWithValue("@catatan", catatan);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal simpan data: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public DataTable ShowData(string query)
        {
            try
            {
                OpenConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, kon);
                DataTable data = new DataTable();
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching data: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
