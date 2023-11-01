namespace P5_4_714220052
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.dt_tanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_komposer = new System.Windows.Forms.CheckBox();
            this.cb_vokal = new System.Windows.Forms.CheckBox();
            this.cb_drum = new System.Windows.Forms.CheckBox();
            this.cb_piano = new System.Windows.Forms.CheckBox();
            this.cb_kon = new System.Windows.Forms.CheckBox();
            this.cb_sax = new System.Windows.Forms.CheckBox();
            this.cb_gitar = new System.Windows.Forms.CheckBox();
            this.cb_biola = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tblTampilkan = new System.Windows.Forms.Button();
            this.tblSelesai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal Lahir";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(220, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 20);
            this.txtName.TabIndex = 3;
            // 
            // cb_gender
            // 
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Location = new System.Drawing.Point(220, 97);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(182, 21);
            this.cb_gender.TabIndex = 4;
            // 
            // dt_tanggalLahir
            // 
            this.dt_tanggalLahir.Location = new System.Drawing.Point(220, 131);
            this.dt_tanggalLahir.Name = "dt_tanggalLahir";
            this.dt_tanggalLahir.Size = new System.Drawing.Size(200, 20);
            this.dt_tanggalLahir.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_komposer);
            this.groupBox1.Controls.Add(this.cb_vokal);
            this.groupBox1.Controls.Add(this.cb_drum);
            this.groupBox1.Controls.Add(this.cb_piano);
            this.groupBox1.Controls.Add(this.cb_kon);
            this.groupBox1.Controls.Add(this.cb_sax);
            this.groupBox1.Controls.Add(this.cb_gitar);
            this.groupBox1.Controls.Add(this.cb_biola);
            this.groupBox1.Location = new System.Drawing.Point(32, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 196);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilihan Kelas";
            // 
            // cb_komposer
            // 
            this.cb_komposer.AutoSize = true;
            this.cb_komposer.Location = new System.Drawing.Point(154, 146);
            this.cb_komposer.Name = "cb_komposer";
            this.cb_komposer.Size = new System.Drawing.Size(80, 17);
            this.cb_komposer.TabIndex = 7;
            this.cb_komposer.Text = "checkBox8";
            this.cb_komposer.UseVisualStyleBackColor = true;
            // 
            // cb_vokal
            // 
            this.cb_vokal.AutoSize = true;
            this.cb_vokal.Location = new System.Drawing.Point(154, 108);
            this.cb_vokal.Name = "cb_vokal";
            this.cb_vokal.Size = new System.Drawing.Size(53, 17);
            this.cb_vokal.TabIndex = 6;
            this.cb_vokal.Text = "Vokal";
            this.cb_vokal.UseVisualStyleBackColor = true;
            // 
            // cb_drum
            // 
            this.cb_drum.AutoSize = true;
            this.cb_drum.Location = new System.Drawing.Point(154, 72);
            this.cb_drum.Name = "cb_drum";
            this.cb_drum.Size = new System.Drawing.Size(51, 17);
            this.cb_drum.TabIndex = 5;
            this.cb_drum.Text = "Drum";
            this.cb_drum.UseVisualStyleBackColor = true;
            // 
            // cb_piano
            // 
            this.cb_piano.AutoSize = true;
            this.cb_piano.Location = new System.Drawing.Point(154, 31);
            this.cb_piano.Name = "cb_piano";
            this.cb_piano.Size = new System.Drawing.Size(53, 17);
            this.cb_piano.TabIndex = 4;
            this.cb_piano.Text = "Piano";
            this.cb_piano.UseVisualStyleBackColor = true;
            // 
            // cb_kon
            // 
            this.cb_kon.AutoSize = true;
            this.cb_kon.Location = new System.Drawing.Point(18, 146);
            this.cb_kon.Name = "cb_kon";
            this.cb_kon.Size = new System.Drawing.Size(75, 17);
            this.cb_kon.TabIndex = 3;
            this.cb_kon.Text = "Konduktor";
            this.cb_kon.UseVisualStyleBackColor = true;
            // 
            // cb_sax
            // 
            this.cb_sax.AutoSize = true;
            this.cb_sax.Location = new System.Drawing.Point(18, 108);
            this.cb_sax.Name = "cb_sax";
            this.cb_sax.Size = new System.Drawing.Size(80, 17);
            this.cb_sax.TabIndex = 2;
            this.cb_sax.Text = "Saxophone";
            this.cb_sax.UseVisualStyleBackColor = true;
            // 
            // cb_gitar
            // 
            this.cb_gitar.AutoSize = true;
            this.cb_gitar.Location = new System.Drawing.Point(18, 72);
            this.cb_gitar.Name = "cb_gitar";
            this.cb_gitar.Size = new System.Drawing.Size(48, 17);
            this.cb_gitar.TabIndex = 1;
            this.cb_gitar.Text = "Gitar";
            this.cb_gitar.UseVisualStyleBackColor = true;
            // 
            // cb_biola
            // 
            this.cb_biola.AutoSize = true;
            this.cb_biola.Location = new System.Drawing.Point(18, 31);
            this.cb_biola.Name = "cb_biola";
            this.cb_biola.Size = new System.Drawing.Size(49, 17);
            this.cb_biola.TabIndex = 0;
            this.cb_biola.Text = "Biola";
            this.cb_biola.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(338, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 196);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilihan Jadwal";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(24, 146);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(129, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Minggu, 13.00 - 17.00";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(24, 108);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(169, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Sabtu && Minggu, 09.00 - 11.00";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(24, 72);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(166, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Selasa && Kamis, 14.00 - 16.00";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(159, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Senin && Rabu, 14.00 - 16.00";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tblTampilkan
            // 
            this.tblTampilkan.Location = new System.Drawing.Point(135, 394);
            this.tblTampilkan.Name = "tblTampilkan";
            this.tblTampilkan.Size = new System.Drawing.Size(75, 23);
            this.tblTampilkan.TabIndex = 8;
            this.tblTampilkan.Text = "Tampilkan";
            this.tblTampilkan.UseVisualStyleBackColor = true;
            // 
            // tblSelesai
            // 
            this.tblSelesai.Location = new System.Drawing.Point(349, 393);
            this.tblSelesai.Name = "tblSelesai";
            this.tblSelesai.Size = new System.Drawing.Size(75, 23);
            this.tblSelesai.TabIndex = 9;
            this.tblSelesai.Text = "Selesai";
            this.tblSelesai.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblSelesai);
            this.Controls.Add(this.tblTampilkan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dt_tanggalLahir);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.DateTimePicker dt_tanggalLahir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_komposer;
        private System.Windows.Forms.CheckBox cb_vokal;
        private System.Windows.Forms.CheckBox cb_drum;
        private System.Windows.Forms.CheckBox cb_piano;
        private System.Windows.Forms.CheckBox cb_kon;
        private System.Windows.Forms.CheckBox cb_sax;
        private System.Windows.Forms.CheckBox cb_gitar;
        private System.Windows.Forms.CheckBox cb_biola;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button tblTampilkan;
        private System.Windows.Forms.Button tblSelesai;
    }
}

