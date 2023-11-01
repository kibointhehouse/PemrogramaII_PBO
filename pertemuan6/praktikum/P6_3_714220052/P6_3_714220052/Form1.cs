using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_714220052
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if ((txtHuruf.Text).All(Char.IsLetter))
            {
                epWarning.SetError(txtHuruf, "");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "Betul!!!!!");
            }

            else
            {
                epWrong.SetError(txtHuruf, "Inputan hanya boleh huruf!");
                epWarning.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }
        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {
            if ((txtAngka.Text).All(Char.IsNumber))
            {
                epCorrect.SetError(txtAngka, "BETULLL!!");
                epWarning.SetError(txtAngka, "");
                epWrong.SetError(txtAngka, "");
            }
            else
            {
                epCorrect.SetError(txtAngka, "");
                epWarning.SetError(txtAngka, "");
                epWrong.SetError(txtAngka, "inputan hanya boleh angkaaaa");
            }
        }

       private void txtEmail_Leave(object sender, EventArgs e)
        {
           if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epWarning.SetError(txtEmail, "");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "Betulllll");
            }

            else
            {
                epWrong.SetError(txtEmail, "Format Email Salah! \nContoh: a@b.c");
                epWarning.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
        }

       private void txtAngka2_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            if (IsNumber(txtAngka1.Text) && IsNumber(txtAngka2.Text))
            {
                double angka1 = Convert.ToDouble(txtAngka1.Text);
                double angka2 = Convert.ToDouble(txtAngka2.Text);

                if (angka1 <= angka2)
                {
                    epWarning.SetError(txtAngka1, "Angka1 harus lebih besar dari Angka2");
                    epWrong.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka1, "");
                }
                else
                {
                    epWarning.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka1, "Betul");
                }
            }
            else
            {
                epWarning.SetError(txtAngka1, "Masukkan angka yang valid");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");
            }
        }

        private bool IsNumber(string text)
        {
            double number;
            return double.TryParse(text, out number);
        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            if (IsNumber(txtAngka1.Text) && IsNumber(txtAngka2.Text))
            {
                int angka1 = Convert.ToInt32(txtAngka1.Text);
                int angka2 = Convert.ToInt32(txtAngka2.Text);

                if (angka1 <= angka2)
                {
                    epWarning.SetError(txtAngka2, "Angka1 harus lebih besar dari Angka2");
                    epWrong.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "");
                }
                else
                {
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "Betul");
                }
            }
            else
            {
                epWarning.SetError(txtAngka2, "");
                epWrong.SetError(txtAngka2, "Inputan hanya boleh angka!");
                epCorrect.SetError(txtAngka2, "");
            }
        }
    }
}
