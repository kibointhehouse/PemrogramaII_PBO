using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateriOOP
{
    internal class Polymorphism
    {
    }



    class Bentuk
    {
        public virtual void Gambar()
        {
            Console.WriteLine("INI ADALAH  BASE CLASS BENTUK");
        }
    }

    class lingkaran : Bentuk
    {
        public override void Gambar()
        {
            // MENGGAMBAR LINGKARAN
            Console.WriteLine("MENGAMBAR LINGKARAN");
        }
    }

    class Persegi : Bentuk
    {
        public override void Gambar()
        {
            //MENGAMMBAR PERSEGI
            Console.WriteLine("MENGGAMBAR PERSEGI");
        }
    }
}
