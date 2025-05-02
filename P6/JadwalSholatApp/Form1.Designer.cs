namespace JadwalSholatApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.toggleAlarm = new System.Windows.Forms.CheckBox();
            this.lblAlarm = new System.Windows.Forms.Label();

            this.lblSubuh = new System.Windows.Forms.Label();
            this.lblDzuhur = new System.Windows.Forms.Label();
            this.lblAshar = new System.Windows.Forms.Label();
            this.lblMaghrib = new System.Windows.Forms.Label();
            this.lblIsya = new System.Windows.Forms.Label();

            this.lblTimeSubuh = new System.Windows.Forms.Label();
            this.lblTimeDzuhur = new System.Windows.Forms.Label();
            this.lblTimeAshar = new System.Windows.Forms.Label();
            this.lblTimeMaghrib = new System.Windows.Forms.Label();
            this.lblTimeIsya = new System.Windows.Forms.Label();

            this.lblWaktuSholat = new System.Windows.Forms.Label();
            this.picClock = new System.Windows.Forms.PictureBox();

            ((System.ComponentModel.ISupportInitialize)(this.picClock)).BeginInit();
            this.SuspendLayout();

            // btnBack
            this.btnBack.Location = new System.Drawing.Point(10, 10);
            this.btnBack.Size = new System.Drawing.Size(40, 30);
            this.btnBack.Text = "<";
            this.btnBack.BackColor = System.Drawing.Color.LightGreen;

            // lblLocation
            this.lblLocation.Location = new System.Drawing.Point(60, 20);
            this.lblLocation.Text = "📍 Nganjuk";
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 12F);

            // toggleAlarm
            this.toggleAlarm.Location = new System.Drawing.Point(200, 20);
            this.toggleAlarm.Size = new System.Drawing.Size(20, 20);
            this.toggleAlarm.Checked = true;

            // lblAlarm
            this.lblAlarm.Location = new System.Drawing.Point(230, 20);
            this.lblAlarm.Text = "Alarm Shalat";
            this.lblAlarm.Font = new System.Drawing.Font("Segoe UI", 10F);

            // Waktu sholat labels
            int labelX = 50, labelY = 80, spaceY = 50;

            this.lblSubuh.Location = new System.Drawing.Point(labelX, labelY);
            this.lblSubuh.Text = "Subuh";
            this.lblSubuh.Font = new System.Drawing.Font("Segoe UI", 12F);

            this.lblTimeSubuh.Location = new System.Drawing.Point(labelX + 100, labelY);
            this.lblTimeSubuh.Text = "04.00";
            this.lblTimeSubuh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTimeSubuh.BackColor = System.Drawing.Color.LightGreen;

            this.lblDzuhur.Location = new System.Drawing.Point(labelX, labelY + spaceY);
            this.lblDzuhur.Text = "Dzuhur";
            this.lblDzuhur.Font = new System.Drawing.Font("Segoe UI", 12F);

            this.lblTimeDzuhur.Location = new System.Drawing.Point(labelX + 100, labelY + spaceY);
            this.lblTimeDzuhur.Text = "11.30";
            this.lblTimeDzuhur.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTimeDzuhur.BackColor = System.Drawing.Color.LightGreen;

            this.lblAshar.Location = new System.Drawing.Point(labelX, labelY + spaceY * 2);
            this.lblAshar.Text = "Ashar";
            this.lblAshar.Font = new System.Drawing.Font("Segoe UI", 12F);

            this.lblTimeAshar.Location = new System.Drawing.Point(labelX + 100, labelY + spaceY * 2);
            this.lblTimeAshar.Text = "14.45 (Now)";
            this.lblTimeAshar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTimeAshar.BackColor = System.Drawing.Color.LightBlue;

            this.lblMaghrib.Location = new System.Drawing.Point(labelX, labelY + spaceY * 3);
            this.lblMaghrib.Text = "Maghrib";
            this.lblMaghrib.Font = new System.Drawing.Font("Segoe UI", 12F);

            this.lblTimeMaghrib.Location = new System.Drawing.Point(labelX + 100, labelY + spaceY * 3);
            this.lblTimeMaghrib.Text = "17.30 (-12m)";
            this.lblTimeMaghrib.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTimeMaghrib.BackColor = System.Drawing.Color.SteelBlue;

            this.lblIsya.Location = new System.Drawing.Point(labelX, labelY + spaceY * 4);
            this.lblIsya.Text = "Isya";
            this.lblIsya.Font = new System.Drawing.Font("Segoe UI", 12F);

            this.lblTimeIsya.Location = new System.Drawing.Point(labelX + 100, labelY + spaceY * 4);
            this.lblTimeIsya.Text = "19.02";
            this.lblTimeIsya.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTimeIsya.BackColor = System.Drawing.Color.LightGreen;

            // lblWaktuSholat
            this.lblWaktuSholat.Location = new System.Drawing.Point(350, 100);
            this.lblWaktuSholat.Text = "Waktu Sholat";
            this.lblWaktuSholat.Font = new System.Drawing.Font("Segoe UI", 14F);

            // picClock
            this.picClock.Location = new System.Drawing.Point(340, 150);
            this.picClock.Size = new System.Drawing.Size(150, 150);
            this.picClock.BackColor = System.Drawing.Color.LightGreen;
            this.picClock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Form1
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.BackColor = System.Drawing.Color.Honeydew;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.toggleAlarm);
            this.Controls.Add(this.lblAlarm);

            this.Controls.Add(this.lblSubuh);
            this.Controls.Add(this.lblTimeSubuh);
            this.Controls.Add(this.lblDzuhur);
            this.Controls.Add(this.lblTimeDzuhur);
            this.Controls.Add(this.lblAshar);
            this.Controls.Add(this.lblTimeAshar);
            this.Controls.Add(this.lblMaghrib);
            this.Controls.Add(this.lblTimeMaghrib);
            this.Controls.Add(this.lblIsya);
            this.Controls.Add(this.lblTimeIsya);

            this.Controls.Add(this.lblWaktuSholat);
            this.Controls.Add(this.picClock);

            this.Text = "Jadwal Sholat App";
            ((System.ComponentModel.ISupportInitialize)(this.picClock)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.CheckBox toggleAlarm;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Label lblSubuh, lblDzuhur, lblAshar, lblMaghrib, lblIsya;
        private System.Windows.Forms.Label lblTimeSubuh, lblTimeDzuhur, lblTimeAshar, lblTimeMaghrib, lblTimeIsya;
        private System.Windows.Forms.Label lblWaktuSholat;
        private System.Windows.Forms.PictureBox picClock;
    }
}
