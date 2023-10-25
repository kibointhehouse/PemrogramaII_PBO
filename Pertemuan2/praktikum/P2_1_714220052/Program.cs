using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_7142252
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("masukan angka pertama anda :");
            double angka1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("masukan angka kedua anda :");
            double angka2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

           double penjumlahan = angka1 + angka2;
            Console.WriteLine("angka1 += angka2 = {0},", penjumlahan);

           double pengurangan = angka1 - angka2;
            Console.WriteLine("angka1 -= angka2 = {0}", pengurangan);

           double perkalian =  angka1 * angka2;
            Console.WriteLine("angka1 *= angka2 = {0}", perkalian);
            
            double pembagian = angka1 / angka2;
            Console.WriteLine("angka1 /= angka2 = {0}", pembagian);
        }
    }
}
