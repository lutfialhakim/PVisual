private readonly CatatanController catatanController = new CatatanController();
private readonly JadwalSholatController sholatController = new JadwalSholatController();

private void Tampil()
{
    DataTable.DataSource = catatanController.TampilkanSemua();
}

private void button1_Click(object sender, EventArgs e)
{
    catatanController.Tambah(dateTimePicker1.Value, richTextBox1.Text);
    Tampil();
}
