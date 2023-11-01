using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714220052
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tblTampilkan_Click(object sender, EventArgs e)
        {
            string jadwal = "";
            string kelas = "";

            if (txtName.Text == "")
            {
                MessageBox.Show("Nama harus diisi!",
                                    "Warning!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cb_gender.Text != "Laki-laki" && cb_gender.Text != "Perempuan")
            {
                MessageBox.Show("Jenis kelamin tidak valid!",
                                    "Warning!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cb_biola.Checked)
            {
                kelas += "Biola, ";
            }
            if (cb_gitar.Checked)
            {
                kelas += "Gitar, ";
            }
            if (cb_sax.Checked)
            {
                kelas += "Saxophone, ";
            }
            if (cb_kon.Checked)
            {
                kelas += "Konduktor, ";
            }
            if (cb_piano.Checked)
            {
                kelas += "Piano, ";
            }
            if (cb_drum.Checked)
            {
                kelas += "Drum, ";
            }
            if (cb_vokal.Checked)
            {
                kelas += "Vokal, ";
            }
            if (cb_komposer.Checked)
            {
                kelas += "Komposer, ";
            }

            kelas = kelas.TrimEnd(',', ' ');

            if (string.IsNullOrWhiteSpace(kelas))
            {
                MessageBox.Show("Harus memilih salah satu atau lebih dari pilihan kelas!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (radioButton1.Checked == true)
            {
                jadwal = "Senin & Rabu, 14.00 - 16.00";
            }
            else if (radioButton2.Checked == true)
            {
                jadwal = "Selasa & Kamis, 14.00 - 16.00";
            }
            else if (radioButton3.Checked == true)
            {
                jadwal = "Sabtu & Minggu, 09.00 - 11.00";
            }
            else if (radioButton4.Checked == true)
            {
                jadwal = "Minggu, 13.00 - 17.00";
            }
            else
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan jadwal!",
                    "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            MessageBox.Show("Nama: " + txtName.Text +
                "\nJenis Kelamin: " + cb_gender.Text +
                "\nTanggal Lahir: " + dt_tanggalLahir.Text +
                "\nPilihan Kelas: " + kelas +
                "\nPilihan Jadwal: " + jadwal,
                "Informasi Pendaftaran",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tblSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
