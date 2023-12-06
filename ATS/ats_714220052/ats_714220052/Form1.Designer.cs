namespace ats_714220052
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.rbLaki = new System.Windows.Forms.RadioButton();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.cbProgramStudi = new System.Windows.Forms.ComboBox();
            this.txtTahun = new System.Windows.Forms.TextBox();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.gbKurikulum = new System.Windows.Forms.GroupBox();
            this.rbKurikulumM = new System.Windows.Forms.RadioButton();
            this.rbKurikulum13 = new System.Windows.Forms.RadioButton();
            this.rbKurikulum06 = new System.Windows.Forms.RadioButton();
            this.gbMatkul = new System.Windows.Forms.GroupBox();
            this.cbManajemenRP = new System.Windows.Forms.CheckBox();
            this.cbSisOp = new System.Windows.Forms.CheckBox();
            this.cbJarkom = new System.Windows.Forms.CheckBox();
            this.cbPLog = new System.Windows.Forms.CheckBox();
            this.cbPendidikan = new System.Windows.Forms.CheckBox();
            this.cbAgama = new System.Windows.Forms.CheckBox();
            this.cbFisika = new System.Windows.Forms.CheckBox();
            this.cbPemo4 = new System.Windows.Forms.CheckBox();
            this.cbPemo3 = new System.Windows.Forms.CheckBox();
            this.cbPemo2 = new System.Windows.Forms.CheckBox();
            this.cbPemo1 = new System.Windows.Forms.CheckBox();
            this.cbMTK = new System.Windows.Forms.CheckBox();
            this.btnMataKuliah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbKurikulum.SuspendLayout();
            this.gbMatkul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Program Studi";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tahun Akademik";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Semester";
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(109, 43);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(192, 20);
            this.txtNIM.TabIndex = 7;
            this.txtNIM.TextChanged += new System.EventHandler(this.txtNIM_TextChanged);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(109, 75);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(192, 20);
            this.txtNama.TabIndex = 8;
            this.txtNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
            // 
            // rbLaki
            // 
            this.rbLaki.AutoSize = true;
            this.rbLaki.Location = new System.Drawing.Point(125, 104);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(68, 17);
            this.rbLaki.TabIndex = 9;
            this.rbLaki.TabStop = true;
            this.rbLaki.Text = "Laki-Laki";
            this.rbLaki.UseVisualStyleBackColor = true;
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.Location = new System.Drawing.Point(226, 104);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(79, 17);
            this.rbPerempuan.TabIndex = 10;
            this.rbPerempuan.TabStop = true;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = true;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(109, 137);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(192, 67);
            this.txtAlamat.TabIndex = 11;
            this.txtAlamat.TextChanged += new System.EventHandler(this.txtAlamat_TextChanged);
            // 
            // cbProgramStudi
            // 
            this.cbProgramStudi.FormattingEnabled = true;
            this.cbProgramStudi.Items.AddRange(new object[] {
            "D3 Teknik Informatila",
            "D4 Teknik Informatika"});
            this.cbProgramStudi.Location = new System.Drawing.Point(517, 35);
            this.cbProgramStudi.Name = "cbProgramStudi";
            this.cbProgramStudi.Size = new System.Drawing.Size(192, 21);
            this.cbProgramStudi.TabIndex = 12;
            this.cbProgramStudi.TextChanged += new System.EventHandler(this.cbProgramStudi_TextChanged);
            // 
            // txtTahun
            // 
            this.txtTahun.Location = new System.Drawing.Point(532, 69);
            this.txtTahun.Name = "txtTahun";
            this.txtTahun.Size = new System.Drawing.Size(177, 20);
            this.txtTahun.TabIndex = 13;
            this.txtTahun.TextChanged += new System.EventHandler(this.txtTahun_TextChanged);
            // 
            // txtSemester
            // 
            this.txtSemester.Location = new System.Drawing.Point(495, 95);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(192, 20);
            this.txtSemester.TabIndex = 14;
            // 
            // gbKurikulum
            // 
            this.gbKurikulum.Controls.Add(this.rbKurikulumM);
            this.gbKurikulum.Controls.Add(this.rbKurikulum13);
            this.gbKurikulum.Controls.Add(this.rbKurikulum06);
            this.gbKurikulum.Location = new System.Drawing.Point(23, 238);
            this.gbKurikulum.Name = "gbKurikulum";
            this.gbKurikulum.Size = new System.Drawing.Size(200, 100);
            this.gbKurikulum.TabIndex = 15;
            this.gbKurikulum.TabStop = false;
            this.gbKurikulum.Text = "Kurikulum Pilihan";
            // 
            // rbKurikulumM
            // 
            this.rbKurikulumM.AutoSize = true;
            this.rbKurikulumM.Location = new System.Drawing.Point(7, 67);
            this.rbKurikulumM.Name = "rbKurikulumM";
            this.rbKurikulumM.Size = new System.Drawing.Size(116, 17);
            this.rbKurikulumM.TabIndex = 2;
            this.rbKurikulumM.TabStop = true;
            this.rbKurikulumM.Text = "Kurikulum Merdeka";
            this.rbKurikulumM.UseVisualStyleBackColor = true;
            this.rbKurikulumM.CheckedChanged += new System.EventHandler(this.rbKurikulumM_CheckedChanged);
            // 
            // rbKurikulum13
            // 
            this.rbKurikulum13.AutoSize = true;
            this.rbKurikulum13.Location = new System.Drawing.Point(7, 43);
            this.rbKurikulum13.Name = "rbKurikulum13";
            this.rbKurikulum13.Size = new System.Drawing.Size(98, 17);
            this.rbKurikulum13.TabIndex = 1;
            this.rbKurikulum13.TabStop = true;
            this.rbKurikulum13.Text = "Kurikulum 2013";
            this.rbKurikulum13.UseVisualStyleBackColor = true;
            this.rbKurikulum13.CheckedChanged += new System.EventHandler(this.rbKurikulum13_CheckedChanged);
            // 
            // rbKurikulum06
            // 
            this.rbKurikulum06.AutoSize = true;
            this.rbKurikulum06.Location = new System.Drawing.Point(7, 20);
            this.rbKurikulum06.Name = "rbKurikulum06";
            this.rbKurikulum06.Size = new System.Drawing.Size(98, 17);
            this.rbKurikulum06.TabIndex = 0;
            this.rbKurikulum06.TabStop = true;
            this.rbKurikulum06.Text = "Kurikulum 2006";
            this.rbKurikulum06.UseVisualStyleBackColor = true;
            this.rbKurikulum06.CheckedChanged += new System.EventHandler(this.rbKurikulum06_CheckedChanged);
            // 
            // gbMatkul
            // 
            this.gbMatkul.Controls.Add(this.cbManajemenRP);
            this.gbMatkul.Controls.Add(this.cbSisOp);
            this.gbMatkul.Controls.Add(this.cbJarkom);
            this.gbMatkul.Controls.Add(this.cbPLog);
            this.gbMatkul.Controls.Add(this.cbPendidikan);
            this.gbMatkul.Controls.Add(this.cbAgama);
            this.gbMatkul.Controls.Add(this.cbFisika);
            this.gbMatkul.Controls.Add(this.cbPemo4);
            this.gbMatkul.Controls.Add(this.cbPemo3);
            this.gbMatkul.Controls.Add(this.cbPemo2);
            this.gbMatkul.Controls.Add(this.cbPemo1);
            this.gbMatkul.Controls.Add(this.cbMTK);
            this.gbMatkul.Location = new System.Drawing.Point(288, 238);
            this.gbMatkul.Name = "gbMatkul";
            this.gbMatkul.Size = new System.Drawing.Size(500, 130);
            this.gbMatkul.TabIndex = 16;
            this.gbMatkul.TabStop = false;
            this.gbMatkul.Text = "Mata Kuliah Pilihan";
            // 
            // cbManajemenRP
            // 
            this.cbManajemenRP.AutoSize = true;
            this.cbManajemenRP.Location = new System.Drawing.Point(316, 106);
            this.cbManajemenRP.Name = "cbManajemenRP";
            this.cbManajemenRP.Size = new System.Drawing.Size(148, 17);
            this.cbManajemenRP.TabIndex = 11;
            this.cbManajemenRP.Text = "Manajemen Rantai Pasok";
            this.cbManajemenRP.UseVisualStyleBackColor = true;
            // 
            // cbSisOp
            // 
            this.cbSisOp.AutoSize = true;
            this.cbSisOp.Location = new System.Drawing.Point(285, 82);
            this.cbSisOp.Name = "cbSisOp";
            this.cbSisOp.Size = new System.Drawing.Size(96, 17);
            this.cbSisOp.TabIndex = 10;
            this.cbSisOp.Text = "Sistem Operasi";
            this.cbSisOp.UseVisualStyleBackColor = true;
            // 
            // cbJarkom
            // 
            this.cbJarkom.AutoSize = true;
            this.cbJarkom.Location = new System.Drawing.Point(285, 53);
            this.cbJarkom.Name = "cbJarkom";
            this.cbJarkom.Size = new System.Drawing.Size(114, 17);
            this.cbJarkom.TabIndex = 9;
            this.cbJarkom.Text = "Jaringan Komputer";
            this.cbJarkom.UseVisualStyleBackColor = true;
            // 
            // cbPLog
            // 
            this.cbPLog.AutoSize = true;
            this.cbPLog.Location = new System.Drawing.Point(285, 30);
            this.cbPLog.Name = "cbPLog";
            this.cbPLog.Size = new System.Drawing.Size(114, 17);
            this.cbPLog.TabIndex = 8;
            this.cbPLog.Text = "Pengantar Logistik";
            this.cbPLog.UseVisualStyleBackColor = true;
            // 
            // cbPendidikan
            // 
            this.cbPendidikan.AutoSize = true;
            this.cbPendidikan.Location = new System.Drawing.Point(153, 106);
            this.cbPendidikan.Name = "cbPendidikan";
            this.cbPendidikan.Size = new System.Drawing.Size(157, 17);
            this.cbPendidikan.TabIndex = 7;
            this.cbPendidikan.Text = "Pendidikan Kewarnegaraan";
            this.cbPendidikan.UseVisualStyleBackColor = true;
            // 
            // cbAgama
            // 
            this.cbAgama.AutoSize = true;
            this.cbAgama.Location = new System.Drawing.Point(153, 82);
            this.cbAgama.Name = "cbAgama";
            this.cbAgama.Size = new System.Drawing.Size(109, 17);
            this.cbAgama.TabIndex = 6;
            this.cbAgama.Text = "Pedidikan Agama";
            this.cbAgama.UseVisualStyleBackColor = true;
            // 
            // cbFisika
            // 
            this.cbFisika.AutoSize = true;
            this.cbFisika.Location = new System.Drawing.Point(153, 53);
            this.cbFisika.Name = "cbFisika";
            this.cbFisika.Size = new System.Drawing.Size(53, 17);
            this.cbFisika.TabIndex = 5;
            this.cbFisika.Text = "Fisika";
            this.cbFisika.UseVisualStyleBackColor = true;
            // 
            // cbPemo4
            // 
            this.cbPemo4.AutoSize = true;
            this.cbPemo4.Location = new System.Drawing.Point(153, 30);
            this.cbPemo4.Name = "cbPemo4";
            this.cbPemo4.Size = new System.Drawing.Size(97, 17);
            this.cbPemo4.TabIndex = 4;
            this.cbPemo4.Text = "Pemograman 4";
            this.cbPemo4.UseVisualStyleBackColor = true;
            // 
            // cbPemo3
            // 
            this.cbPemo3.AutoSize = true;
            this.cbPemo3.Location = new System.Drawing.Point(7, 106);
            this.cbPemo3.Name = "cbPemo3";
            this.cbPemo3.Size = new System.Drawing.Size(97, 17);
            this.cbPemo3.TabIndex = 3;
            this.cbPemo3.Text = "Pemograman 3";
            this.cbPemo3.UseVisualStyleBackColor = true;
            // 
            // cbPemo2
            // 
            this.cbPemo2.AutoSize = true;
            this.cbPemo2.Location = new System.Drawing.Point(7, 82);
            this.cbPemo2.Name = "cbPemo2";
            this.cbPemo2.Size = new System.Drawing.Size(97, 17);
            this.cbPemo2.TabIndex = 2;
            this.cbPemo2.Text = "Pemograman 2";
            this.cbPemo2.UseVisualStyleBackColor = true;
            // 
            // cbPemo1
            // 
            this.cbPemo1.AutoSize = true;
            this.cbPemo1.Location = new System.Drawing.Point(7, 53);
            this.cbPemo1.Name = "cbPemo1";
            this.cbPemo1.Size = new System.Drawing.Size(97, 17);
            this.cbPemo1.TabIndex = 1;
            this.cbPemo1.Text = "Pemograman 1";
            this.cbPemo1.UseVisualStyleBackColor = true;
            // 
            // cbMTK
            // 
            this.cbMTK.AutoSize = true;
            this.cbMTK.Location = new System.Drawing.Point(7, 30);
            this.cbMTK.Name = "cbMTK";
            this.cbMTK.Size = new System.Drawing.Size(81, 17);
            this.cbMTK.TabIndex = 0;
            this.cbMTK.Text = "Matematika";
            this.cbMTK.UseVisualStyleBackColor = true;
            // 
            // btnMataKuliah
            // 
            this.btnMataKuliah.Location = new System.Drawing.Point(476, 153);
            this.btnMataKuliah.Name = "btnMataKuliah";
            this.btnMataKuliah.Size = new System.Drawing.Size(122, 23);
            this.btnMataKuliah.TabIndex = 17;
            this.btnMataKuliah.Text = "Pilih Mata Kuliah";
            this.btnMataKuliah.UseVisualStyleBackColor = true;
            this.btnMataKuliah.Click += new System.EventHandler(this.btnMataKuliah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(148, 393);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 18;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(323, 392);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 19;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 423);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnMataKuliah);
            this.Controls.Add(this.gbMatkul);
            this.Controls.Add(this.gbKurikulum);
            this.Controls.Add(this.txtSemester);
            this.Controls.Add(this.txtTahun);
            this.Controls.Add(this.cbProgramStudi);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.rbPerempuan);
            this.Controls.Add(this.rbLaki);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbKurikulum.ResumeLayout(false);
            this.gbKurikulum.PerformLayout();
            this.gbMatkul.ResumeLayout(false);
            this.gbMatkul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.RadioButton rbLaki;
        private System.Windows.Forms.RadioButton rbPerempuan;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.ComboBox cbProgramStudi;
        private System.Windows.Forms.TextBox txtTahun;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.GroupBox gbKurikulum;
        private System.Windows.Forms.RadioButton rbKurikulum06;
        private System.Windows.Forms.RadioButton rbKurikulumM;
        private System.Windows.Forms.RadioButton rbKurikulum13;
        private System.Windows.Forms.GroupBox gbMatkul;
        private System.Windows.Forms.CheckBox cbAgama;
        private System.Windows.Forms.CheckBox cbFisika;
        private System.Windows.Forms.CheckBox cbPemo4;
        private System.Windows.Forms.CheckBox cbPemo3;
        private System.Windows.Forms.CheckBox cbPemo2;
        private System.Windows.Forms.CheckBox cbPemo1;
        private System.Windows.Forms.CheckBox cbMTK;
        private System.Windows.Forms.CheckBox cbManajemenRP;
        private System.Windows.Forms.CheckBox cbSisOp;
        private System.Windows.Forms.CheckBox cbJarkom;
        private System.Windows.Forms.CheckBox cbPLog;
        private System.Windows.Forms.CheckBox cbPendidikan;
        private System.Windows.Forms.Button btnMataKuliah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
    }
}

