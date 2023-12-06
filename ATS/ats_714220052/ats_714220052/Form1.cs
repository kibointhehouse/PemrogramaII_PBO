using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ats_714220052
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(735, 258);
            gbMatkul.Enabled = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMataKuliah_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (string.IsNullOrEmpty(txtNIM.Text))
            {
                errorMessage += "NIM belum diisi\n";
            }
            else
            {
                if (!txtNIM.Text.All(char.IsNumber))
                {
                    errorMessage += "NIM harus berupa angka\n";
                }
                else
                {
                    if (txtNIM.Text.Length != 9)
                    {
                        errorMessage += "NIM harus terdiri dari 9 angka!\n";
                    }
                }
            }


            if (string.IsNullOrEmpty(txtNama.Text))
            {
                errorMessage += "Nama belum diisi\n";
            }
            else
            {
                if (txtNama.Text.All(char.IsNumber))
                {
                    errorMessage += "Nama harus berupa huruf\n";
                }
            }



            if (!rbLaki.Checked && !rbPerempuan.Checked)
            {
                errorMessage += "Jenis Kelamin belum diisi\n";
            }
            if (string.IsNullOrEmpty(txtAlamat.Text))
            {
                errorMessage += "Alamat belum diisi\n";
            }

            if (cbProgramStudi.SelectedIndex == -1)
            {
                errorMessage += "Program Studi belum diisi\n";
            }
            else
            {
                if ((cbProgramStudi.Text != "D3 Teknik Informatika") && (cbProgramStudi.Text != "D4 Teknik Informatika"))
                {
                    errorMessage += "Program Studi tidak sesuai\n";
                }
            }

            if (string.IsNullOrEmpty(txtTahun.Text))
            {
                errorMessage += "Tahun Akademik belum diisi\n";
            }
            else
            {
                if (!Regex.IsMatch(txtTahun.Text, @"^\d{4}/\d{4}$"))
                {
                    errorMessage += "Tahun Akademik tidak sesuai\n";
                }
            }


            if (string.IsNullOrEmpty(txtSemester.Text))
            {
                errorMessage += "Semester belum diisi\n";
            }
            else
            {
                if (!int.TryParse(txtSemester.Text, out int inputSmt))
                {
                    errorMessage += "Semester harus diisi dengan angka\n";
                }
                else if (inputSmt <= 0 || inputSmt > 10)
                {
                    errorMessage += "Semester harus di antara 1 dan 10";
                }
            }

            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(
                    "Data Lengkap!",
                    "Informasi Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Size = new Size(735, 462);
                gbMatkul.Enabled = false;
            }
            else
            {
                MessageBox.Show(
                    errorMessage,
                    "Informasi Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtNIM_TextChanged(object sender, EventArgs e)
        {
            if (txtNIM.Text == "")
            {
                epWarning.SetError(txtNIM, "NIM tidak boleh kosong!");
                epWrong.SetError(txtNIM, "");
                epCorrect.SetError(txtNIM, "");
            }
            else
            {
                if (!txtNIM.Text.All(char.IsNumber))
                {
                    epWarning.SetError(txtNIM, "");
                    epWrong.SetError(txtNIM, "NIM harus berupa angka!");
                    epCorrect.SetError(txtNIM, "");
                }
                else
                {
                    if (txtNIM.Text.Length != 9)
                    {
                        epWarning.SetError(txtNIM, "NIM harus terdiri dari 9 angka");
                        epWrong.SetError(txtNIM, "");
                        epCorrect.SetError(txtNIM, "");
                    }
                    else
                    {
                        if ((txtNIM.Text).All(char.IsNumber))
                        {
                            epWarning.SetError(txtNIM, "");
                            epWrong.SetError(txtNIM, "");
                            epCorrect.SetError(txtNIM, "NIM Valid");
                        }
                    }
                }
            }

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNama.Text) || string.IsNullOrWhiteSpace(txtNama.Text))
            {
                epWarning.SetError(txtNama, "Nama tidak boleh kosong!");
                epWrong.SetError(txtNama, "");
                epCorrect.SetError(txtNama, "");
            }
            else
            {
                if (txtNama.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    epWarning.SetError(txtNama, "");
                    epWrong.SetError(txtNama, "");
                    epCorrect.SetError(txtNama, "Nama Valid");
                }
                else
                {
                    epWarning.SetError(txtNama, "");
                    epWrong.SetError(txtNama, "Nama harus berupa huruf!");
                    epCorrect.SetError(txtNama, "");
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void cbProgramStudi_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbProgramStudi.Text))
            {
                epWarning.SetError(cbProgramStudi, "Program Studi tidak boleh kosong!");
                epWrong.SetError(cbProgramStudi, "");
                epCorrect.SetError(cbProgramStudi, "");
            }
            else
            {
                if ((cbProgramStudi.Text != "D3 Teknik Informatika") && (cbProgramStudi.Text != "D4 Teknik Informatika"))
                {
                    epWarning.SetError(cbProgramStudi, "");
                    epWrong.SetError(cbProgramStudi, "Program Studi tidak valid!");
                    epCorrect.SetError(cbProgramStudi, "");
                }
                else
                {
                    epWarning.SetError(cbProgramStudi, "");
                    epWrong.SetError(cbProgramStudi, "");
                    epCorrect.SetError(cbProgramStudi, "Program Studi valid");
                }
            }
        }

        private void txtTahun_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtTahun.Text, @"^\d{4}/\d{4}$"))
            {
                epWarning.SetError(txtTahun, "");
                epWrong.SetError(txtTahun, "");
                epCorrect.SetError(txtTahun, "Tahun Akademik Studi valid");
            }
            else
            {
                epWarning.SetError(txtTahun, "");
                epWrong.SetError(txtTahun, "Tahun Akademik Studi tidak valid\nContoh Tahun Akademik yang valid: 2023/2024");
                epCorrect.SetError(txtTahun, "");
            }
        }

        private void txtSemester_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSemester.Text))
            {
                epWarning.SetError(txtSemester, "Semester tidak boleh kosong!");
                epWrong.SetError(txtSemester, "");
                epCorrect.SetError(txtSemester, "");
            }
            else
            {
                if (int.TryParse(txtSemester.Text, out int inputSmt) && inputSmt > 0 && inputSmt <= 10)
                {
                    epWarning.SetError(txtSemester, "");
                    epWrong.SetError(txtSemester, "");
                    epCorrect.SetError(txtSemester, "Semester Valid");
                }
                else
                {
                    epWarning.SetError(txtSemester, "Semester harus berupa angka dan di antara 1 sampai 10!");
                    epWrong.SetError(txtSemester, "");
                    epCorrect.SetError(txtSemester, "");
                }
            }

        }

        private void txtAlamat_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAlamat.Text))
            {
                epWarning.SetError(txtAlamat, "Alamat tidak boleh kosong!");
                epWrong.SetError(txtAlamat, "");
                epCorrect.SetError(txtAlamat, "");
            }
            else
            {
                epWarning.SetError(txtAlamat, "");
                epWrong.SetError(txtAlamat, "");
                epCorrect.SetError(txtAlamat, "Alamat telah diisi");
            }
        }

        private void rbKurikulum06_CheckedChanged(object sender, EventArgs e)
        {
            gbMatkul.Enabled = true;
            if (rbKurikulum06.Checked)
            {
                cbPLog.Enabled = false;
                cbPLog.Checked = false;
                cbManajemenRP.Enabled = false;
                cbManajemenRP.Checked = false;
                cbMTK.Enabled = true;
                cbPemo1.Enabled = true;
                cbPemo2.Enabled = true;
                cbPemo3.Enabled = true;
                cbPemo4.Enabled = true;
                cbFisika.Enabled = true;
                cbAgama.Enabled = true;
                cbPendidikan.Enabled = true;
                cbJarkom.Enabled = true;
                cbSisOp.Enabled = true;

            }
        }

        private void rbKurikulum13_CheckedChanged(object sender, EventArgs e)
        {
            gbMatkul.Enabled = true;
            if (rbKurikulum13.Checked)
            {
                cbPLog.Enabled = true;
                cbManajemenRP.Enabled = true;
                cbMTK.Enabled = true;
                cbPemo1.Enabled = true;
                cbPemo2.Enabled = true;
                cbPemo3.Enabled = true;
                cbPemo4.Enabled = true;
                cbFisika.Enabled = false;
                cbFisika.Checked = false;
                cbAgama.Enabled = true;
                cbPendidikan.Enabled = false;
                cbPendidikan.Checked = false;
                cbJarkom.Enabled = true;
                cbSisOp.Enabled = true;

            }
        }

        private void rbKurikulumM_CheckedChanged(object sender, EventArgs e)
        {
            gbMatkul.Enabled = true;
            if (rbKurikulumM.Checked)
            {
                cbPLog.Enabled = false;
                cbPLog.Checked = false;
                cbManajemenRP.Enabled = true;
                cbMTK.Enabled = false;
                cbMTK.Checked = false;
                cbPemo1.Enabled = true;
                cbPemo2.Enabled = true;
                cbPemo3.Enabled = true;
                cbPemo4.Enabled = true;
                cbFisika.Enabled = false;
                cbFisika.Checked = false;
                cbAgama.Enabled = true;
                cbPendidikan.Enabled = true;
                cbJarkom.Enabled = true;
                cbSisOp.Enabled = true;

            }

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string jenisKelamin = "";

            if (rbLaki.Checked == true)
            {
                jenisKelamin = "Laki - Laki";
            }
            else if (rbPerempuan.Checked == true)
            {
                jenisKelamin = "Perempuan";
            }

            string kurikulum = "";
            string matkul = "";

            if (rbKurikulum06.Checked == true)
            {
                kurikulum = "Kurikulum 2006";
            }
            else if (rbKurikulum13.Checked == true)
            {
                kurikulum = "Kurikulum 2013";
            }
            else if (rbKurikulumM.Checked == true)
            {
                kurikulum = "Kurikulum Merdeka";
            }
            else
            {
                MessageBox.Show("Harus memilih Kurikulum!",
                    "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbMTK.Checked == true)
            {
                matkul += "Matematika, ";
            }
            if (cbPemo1.Checked == true)
            {
                matkul += "Pemrograman 1, ";
            }
            if (cbPemo2.Checked == true)
            {
                matkul += "Pemrograman 2, ";
            }
            if (cbPemo3.Checked == true)
            {
                matkul += "Pemrograman 3, ";
            }
            if (cbPemo4.Checked == true)
            {
                matkul += "Pemrograman 4, ";
            }
            if (cbFisika.Checked == true)
            {
                matkul += "Fisika, ";
            }
            if (cbAgama.Checked == true)
            {
                matkul += "Pendidikan Agama, ";
            }
            if (cbPendidikan.Checked == true)
            {
                matkul += "Pendidikan Kewarganegaraan, ";
            }
            if (cbPLog.Checked == true)
            {
                matkul += "Pengantar Logistik, ";
            }
            if (cbJarkom.Checked == true)
            {
                matkul += "Jaringan Komputer, ";
            }
            if (cbSisOp.Checked == true)
            {
                matkul += "Sistem Operasi, ";
            }
            if (cbManajemenRP.Checked == true)
            {
                matkul += "Manajemen Rantai Pasok, ";
            }

            matkul = matkul.TrimEnd(',', ' ');

            if (String.IsNullOrWhiteSpace(matkul))
            {
                MessageBox.Show("Harus memilih salah satu dari Mata Kuliah",
                    "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string errorMessage = "";

            if (string.IsNullOrEmpty(txtNIM.Text))
            {
                errorMessage += "NIM belum diisi\n";
            }
            else
            {
                if (!txtNIM.Text.All(char.IsNumber))
                {
                    errorMessage += "NIM harus berupa angka\n";
                }
                else
                {
                    if (txtNIM.Text.Length != 9)
                    {
                        errorMessage += "NIM harus terdiri dari 9 angka!\n";
                    }
                }
            }


            if (string.IsNullOrEmpty(txtNama.Text))
            {
                errorMessage += "Nama belum diisi\n";
            }
            else
            {
                if (txtNama.Text.All(char.IsNumber))
                {
                    errorMessage += "Nama harus berupa huruf\n";
                }
            }



            if (!rbLaki.Checked && !rbPerempuan.Checked)
            {
                errorMessage += "Jenis Kelamin belum diisi\n";
            }
            if (string.IsNullOrEmpty(txtAlamat.Text))
            {
                errorMessage += "Alamat belum diisi\n";
            }

            if (cbProgramStudi.SelectedIndex == -1)
            {
                errorMessage += "Program Studi belum diisi\n";
            }
            else
            {
                if ((cbProgramStudi.Text != "D3 Teknik Informatika") && (cbProgramStudi.Text != "D4 Teknik Informatika"))
                {
                    errorMessage += "Program Studi tidak sesuai\n";
                }
            }

            if (string.IsNullOrEmpty(txtTahun.Text))
            {
                errorMessage += "Tahun Akademik belum diisi\n";
            }
            else
            {
                if (!Regex.IsMatch(txtTahun.Text, @"^\d{4}/\d{4}$"))
                {
                    errorMessage += "Tahun Akademik tidak sesuai\n";
                }
            }


            if (string.IsNullOrEmpty(txtSemester.Text))
            {
                errorMessage += "Semester belum diisi\n";
            }
            else
            {
                if (!int.TryParse(txtSemester.Text, out int inputSmt))
                {
                    errorMessage += "Semester harus diisi dengan angka\n";
                }
                else if (inputSmt <= 0 || inputSmt > 10)
                {
                    errorMessage += "Semester harus di antara 1 dan 10";
                }
            }

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(
                    "Data Belum Lengkap", "Informasi Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(errorMessage))
                {
                    MessageBox.Show(
                        "Data Lengkap!",
                        "Informasi Data",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Size = new Size(735, 500);
                    gbMatkul.Enabled = false;
                }
                else
                {
                    MessageBox.Show(
                        errorMessage,
                        "Informasi Data",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


            MessageBox.Show("NIM : " + txtNIM.Text +
                "\nNama : " + txtNama.Text +
                "\nJenis Kelamin : " + jenisKelamin +
                "\nAlamat : " + txtAlamat.Text +
                "\nProgram Studi : " + cbProgramStudi.Text +
                "\nTahun Akademik : " + txtTahun.Text +
                "\nSemester : " + txtSemester.Text +
                "\n=======================================" +
                "\nKurikulum : " + kurikulum +
                "\nMata Kuliah : " + matkul,
                "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                    epWarning.SetError(textBox, "");
                    epWrong.SetError(textBox, "");
                    epCorrect.SetError(textBox, "");
                }
                else if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                    epWarning.SetError(comboBox, "");
                    epWrong.SetError(comboBox, "");
                    epCorrect.SetError(comboBox, "");
                }
                else if (control is GroupBox groupBox)
                {
                    foreach (Control innerControl in groupBox.Controls)
                    {
                        if (innerControl is RadioButton innerRadioButton)
                        {
                            innerRadioButton.Checked = false;
                        }
                        else if (innerControl is CheckBox innerCheckBox)
                        {
                            innerCheckBox.Checked = false;
                        }
                    }
                }
            }
            this.Size = new Size(811, 462);
            gbMatkul.Enabled = false;
        }
    }
}





