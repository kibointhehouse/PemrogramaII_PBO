using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220052
{
    public class Makanan
    { //field
        private string merek;
        private int tahunProduksi;

        //constructor

        public Makanan(string merek,int tahunProduksi)
        {
            this.merek = merek;
            this.tahunProduksi = tahunProduksi;

        }

        //propety
        public string Merek
        {
            get { return merek; }
            set { merek = value; }
        }

        public int TahunProduksi
        {
            get { return tahunProduksi; }
            set { tahunProduksi = value; }
        }

        //method
        public virtual void Informasi()
        {
            Console.WriteLine($"Makanan ini {Merek} diproduksi pada tahun {TahunProduksi}");
        }

    }
}
