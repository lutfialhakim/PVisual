using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace JadwalSholat
{
    internal class koneksi
    {
        string connectionstring = "Server=localhost;Database=jadwal;Uid=root;Pwd=;";
        MySqlConnection kon;

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
            string query = "UPDATE catatan SET tgl = @tgl, catatan = @catatan WHERE No = @no";
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
            string query = "DELETE FROM catatan WHERE No = @no";
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


        public object GetJadwalSholat(DateTime tanggal)
        {
            string query = "SELECT subuh, dzuhur, ashar, maghrib, isya FROM jadwal_sholat WHERE tgl = @tgl";
            try
            {
                using (MySqlConnection kon = new MySqlConnection(connectionstring))
                {
                    kon.Open();
                    MySqlCommand command = new MySqlCommand(query, kon);
                    command.Parameters.AddWithValue("@tgl", tanggal);
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        
                        return new
                        {
                            Subuh = reader["subuh"].ToString(),
                            Dzuhur = reader["dzuhur"].ToString(),
                            Ashar = reader["ashar"].ToString(),
                            Maghrib = reader["maghrib"].ToString(),
                            Isya = reader["isya"].ToString()
                        };
                    }
                    else
                    {
                        throw new Exception("Jadwal sholat untuk tanggal tersebut tidak ditemukan.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching jadwal sholat: " + ex.Message);
            }
        }


        public void ExecuteQuery(string query)
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand(query, kon);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error executing query: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public object ShowData(string query)
        {
            try
            {
                OpenConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, kon);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data.Tables[0];
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
