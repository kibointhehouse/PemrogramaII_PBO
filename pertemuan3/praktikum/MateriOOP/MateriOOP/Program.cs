using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateriOOP
{
    public class Program
    {
        public void tes(string a, int b)
        {
            Console.WriteLine("tes");
        }

        static void Main(string[] args)
        {
            mobil suatumobil = new mobil();
            mobil mobilSaya = new mobil() { nama = "Nissan Skyline", kecepatan = 0, bensin = 30000, posisi = 0 };
            mobilSaya.maju();
            Console.WriteLine(suatumobil.nama);
            Console.WriteLine(suatumobil.bensin);

            Console.WriteLine(mobilSaya.nama);
            Console.WriteLine(mobilSaya.bensin);

            mobil mobilanda = new mobil("angkot",300,500);
            Console.WriteLine(mobilanda.nama);

            PropertyTest prop = new PropertyTest();
            prop.Materi = "Pemograman C#";
            Console.WriteLine(prop.Materi);

            // person kibo = new person();
            //kibo.Nilai = 80;
            //Console.WriteLine(kibo.Nilai);


            Civic c = new Civic();
            Console.WriteLine(c.Roda);
            c.Klakson2();
            c.Klakson();

          lingkaran p = new lingkaran();
            p.Gambar();

            Persegi l = new Persegi();
            p.Gambar();



        }
    }
}
