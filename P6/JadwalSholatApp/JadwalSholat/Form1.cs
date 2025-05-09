using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace JadwalSholat
{
    public partial class Form1 : Form
    {

        koneksi koneksi = new koneksi();

        public void Tampil()
        {
            DataTable.DataSource = koneksi.ShowData("SELECT * FROM catatan");
        }

        public Form1()
        {
            InitializeComponent();
            DataTable.CellClick += DataTable_CellClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tampil();
           
            TampilWaktuSholat(); // Menampilkan waktu sholat
        
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime tanggal = dateTimePicker1.Value;
                string catatan = richTextBox1.Text;

                if (string.IsNullOrWhiteSpace(catatan))
                {
                    MessageBox.Show("Catatan tidak boleh kosong.");
                    return;
                }

                koneksi.InsertNote(tanggal, catatan);
                MessageBox.Show("Data berhasil disimpan!");

                Tampil(); 
                richTextBox1.Clear(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.Message);
            }
        }

        private int selectedNo = -1; 

        private void DataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataTable.Rows[e.RowIndex];
                selectedNo = Convert.ToInt32(row.Cells["No"].Value);
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["tgl"].Value);
                richTextBox1.Text = row.Cells["catatan"].Value.ToString();
            }
        }



        private void dataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Tombol_Hapus_Click(object sender, EventArgs e)
        {
            {
                if (DataTable.SelectedRows.Count > 0)
                {
                    DialogResult confirm = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        try
                        {
                            int no = Convert.ToInt32(DataTable.SelectedRows[0].Cells["No"].Value);
                            koneksi.DeleteNote(no);
                            MessageBox.Show("Data berhasil dihapus.");
                            Tampil(); // refresh data
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Gagal menghapus data: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Pilih baris data yang ingin dihapus terlebih dahulu.");
                }
            }
        }

        private void Tombol_ubah_Click(object sender, EventArgs e)
        {
            if (selectedNo == -1)
            {
                MessageBox.Show("Pilih data yang ingin diubah terlebih dahulu.");
                return;
            }

            DateTime tanggal = dateTimePicker1.Value;
            string catatan = richTextBox1.Text;

            try
            {
                koneksi.UpdateNote(selectedNo, tanggal, catatan);
                MessageBox.Show("Data berhasil diubah.");
                Tampil();
                richTextBox1.Clear();
                selectedNo = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Tombol_LihatJadwal_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TampilWaktuSholat()
        {
            try
            {
                DateTime tanggal = DateTime.Now.Date;
                var jadwal = koneksi.GetJadwalSholat(tanggal);

                if (jadwal != null)
                {
                    dynamic j = jadwal; 

                    Label_Subuh.Text = "Subuh: " + j.Subuh;
                    Label_Dzuhur.Text = "Dzuhur: " + j.Dzuhur;
                    Label_Ashar.Text = "Ashar: " + j.Ashar;
                    Label_Maghrib.Text = "Maghrib: " + j.Maghrib;
                    Label_Isya.Text = "Isya: " + j.Isya;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan jadwal: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
