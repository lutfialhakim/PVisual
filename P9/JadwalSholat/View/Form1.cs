using System;
using System.Windows.Forms;
using JadwalSholat.Controllers;

namespace JadwalSholat.Views
{
    public partial class Form1 : Form
    {
        private NoteController noteController = new NoteController();

        public Form1()
        {
            InitializeComponent();
            LoadNotes();
        }

        private void LoadNotes()
        {
            dataGridView1.DataSource = noteController.GetAllNotes();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            noteController.AddNote(dateTimePicker1.Value, txtCatatan.Text);
            LoadNotes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int no = Convert.ToInt32(dataGridView1.CurrentRow.Cells["no"].Value);
                noteController.UpdateNote(no, dateTimePicker1.Value, txtCatatan.Text);
                LoadNotes();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int no = Convert.ToInt32(dataGridView1.CurrentRow.Cells["no"].Value);
                noteController.DeleteNote(no);
                LoadNotes();
            }
        }
    }
}
