namespace JadwalSholat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Label_Isya = new System.Windows.Forms.Label();
            this.Label_Maghrib = new System.Windows.Forms.Label();
            this.Label_Ashar = new System.Windows.Forms.Label();
            this.Label_Dzuhur = new System.Windows.Forms.Label();
            this.Label_Subuh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tombol_Hapus = new System.Windows.Forms.Button();
            this.Tombol_ubah = new System.Windows.Forms.Button();
            this.Tombol_Simpan = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.Label_Isya);
            this.groupBox1.Controls.Add(this.Label_Maghrib);
            this.groupBox1.Controls.Add(this.Label_Ashar);
            this.groupBox1.Controls.Add(this.Label_Dzuhur);
            this.groupBox1.Controls.Add(this.Label_Subuh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jadwal Sholat";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Label_Isya
            // 
            this.Label_Isya.AutoSize = true;
            this.Label_Isya.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label_Isya.Location = new System.Drawing.Point(66, 341);
            this.Label_Isya.Name = "Label_Isya";
            this.Label_Isya.Size = new System.Drawing.Size(53, 13);
            this.Label_Isya.TabIndex = 5;
            this.Label_Isya.Text = "Isya        :";
            // 
            // Label_Maghrib
            // 
            this.Label_Maghrib.AutoSize = true;
            this.Label_Maghrib.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label_Maghrib.Location = new System.Drawing.Point(62, 314);
            this.Label_Maghrib.Name = "Label_Maghrib";
            this.Label_Maghrib.Size = new System.Drawing.Size(57, 13);
            this.Label_Maghrib.TabIndex = 4;
            this.Label_Maghrib.Text = "Maghrib   :";
            // 
            // Label_Ashar
            // 
            this.Label_Ashar.AutoSize = true;
            this.Label_Ashar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label_Ashar.Location = new System.Drawing.Point(64, 283);
            this.Label_Ashar.Name = "Label_Ashar";
            this.Label_Ashar.Size = new System.Drawing.Size(55, 13);
            this.Label_Ashar.TabIndex = 3;
            this.Label_Ashar.Text = "Ashar      :";
            // 
            // Label_Dzuhur
            // 
            this.Label_Dzuhur.AutoSize = true;
            this.Label_Dzuhur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label_Dzuhur.Location = new System.Drawing.Point(63, 257);
            this.Label_Dzuhur.Name = "Label_Dzuhur";
            this.Label_Dzuhur.Size = new System.Drawing.Size(56, 13);
            this.Label_Dzuhur.TabIndex = 2;
            this.Label_Dzuhur.Text = "Dzuhur    :";
            // 
            // Label_Subuh
            // 
            this.Label_Subuh.AutoSize = true;
            this.Label_Subuh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label_Subuh.Location = new System.Drawing.Point(63, 227);
            this.Label_Subuh.Name = "Label_Subuh";
            this.Label_Subuh.Size = new System.Drawing.Size(56, 13);
            this.Label_Subuh.TabIndex = 1;
            this.Label_Subuh.Text = "Subuh     :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(89, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "JADWAL SHOLAT HARI INI";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Tombol_Hapus);
            this.groupBox2.Controls.Add(this.Tombol_ubah);
            this.groupBox2.Controls.Add(this.Tombol_Simpan);
            this.groupBox2.Location = new System.Drawing.Point(366, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 204);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(87, 81);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(200, 96);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(87, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Catatan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tanggal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Tombol_Hapus
            // 
            this.Tombol_Hapus.Location = new System.Drawing.Point(323, 132);
            this.Tombol_Hapus.Name = "Tombol_Hapus";
            this.Tombol_Hapus.Size = new System.Drawing.Size(75, 23);
            this.Tombol_Hapus.TabIndex = 2;
            this.Tombol_Hapus.Text = "Hapus";
            this.Tombol_Hapus.UseVisualStyleBackColor = true;
            this.Tombol_Hapus.Click += new System.EventHandler(this.Tombol_Hapus_Click);
            // 
            // Tombol_ubah
            // 
            this.Tombol_ubah.Location = new System.Drawing.Point(323, 103);
            this.Tombol_ubah.Name = "Tombol_ubah";
            this.Tombol_ubah.Size = new System.Drawing.Size(75, 23);
            this.Tombol_ubah.TabIndex = 1;
            this.Tombol_ubah.Text = "Ubah";
            this.Tombol_ubah.UseVisualStyleBackColor = true;
            this.Tombol_ubah.Click += new System.EventHandler(this.Tombol_ubah_Click);
            // 
            // Tombol_Simpan
            // 
            this.Tombol_Simpan.Location = new System.Drawing.Point(323, 74);
            this.Tombol_Simpan.Name = "Tombol_Simpan";
            this.Tombol_Simpan.Size = new System.Drawing.Size(75, 23);
            this.Tombol_Simpan.TabIndex = 0;
            this.Tombol_Simpan.Text = "Simpan";
            this.Tombol_Simpan.UseVisualStyleBackColor = true;
            this.Tombol_Simpan.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox3.Controls.Add(this.DataTable);
            this.groupBox3.Location = new System.Drawing.Point(366, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 193);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Catatan";
            // 
            // DataTable
            // 
            this.DataTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Location = new System.Drawing.Point(7, 20);
            this.DataTable.Name = "DataTable";
            this.DataTable.Size = new System.Drawing.Size(409, 167);
            this.DataTable.TabIndex = 0;
            this.DataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Jadwal Sholat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Tombol_Simpan;
        private System.Windows.Forms.Button Tombol_Hapus;
        private System.Windows.Forms.Button Tombol_ubah;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_Isya;
        private System.Windows.Forms.Label Label_Maghrib;
        private System.Windows.Forms.Label Label_Ashar;
        private System.Windows.Forms.Label Label_Dzuhur;
        private System.Windows.Forms.Label Label_Subuh;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

