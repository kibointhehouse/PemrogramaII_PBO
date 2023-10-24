using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220052
{
    //Inheritance
    public class JenisMakanan : Makanan
    {
        private int hargaMakanan;
        //constructor

        public JenisMakanan(string merek, int tahunProduksi, int hargaMakanan) : base(merek, tahunProduksi)
        {
            this.hargaMakanan = hargaMakanan;
        }

       

        // property

        public int HargaMakanan
        {
            get { return hargaMakanan; }
            set { hargaMakanan = value; }
        }

        // method
        public override void Informasi()
        {
            Console.WriteLine($"\nMakanan \"{Merek}\" dengan harga \"{HargaMakanan}\" diproduksi pada tahun \"{TahunProduksi}\".");
        }

    }
}
