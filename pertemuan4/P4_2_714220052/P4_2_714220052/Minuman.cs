using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220052
{
    //Inheritance
    public class Minuman : Makanan
    {
        private string jenis;

        //Constructor

        public Minuman(string merek, int tahunProduksi, string jenis) : base(merek, tahunProduksi)
        {
            this.jenis = jenis;
        }

        //property

        public string Jenis
        {
            get { return jenis; }
            set { jenis = value; }
        }

        //Method
        public override void Informasi()
        {
            Console.WriteLine($"\nMinuman \"{Merek}\" dengan jenis \"{Jenis}\", diproduksi pada tahun \"{TahunProduksi}\".\n");
        }
    }
}
