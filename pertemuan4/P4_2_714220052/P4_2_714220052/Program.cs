using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220052
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //polymorphism
            Makanan makanan1 = new JenisMakanan("Chitato",1990 , 10000);
            Makanan makanan2 = new Minuman("Sprite", 1961, "soda");

            makanan1.Informasi();
            makanan2.Informasi();


        }
    }
}
