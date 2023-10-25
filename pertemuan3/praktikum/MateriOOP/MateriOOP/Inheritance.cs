using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateriOOP
{
    internal class Inheritance
    {
    }



    public class car
    {
        public int Roda { get; set; }
        public int Tahun { get; set; }




        public void Klakson2()
        {
            Console.WriteLine("TOTTTTTTTT");
        }
    }

    

    class Civic : car
    {
        public Civic()
        {
            Roda = 4;
        }

        public void Klakson()
        {
            Console.WriteLine("TINNNN");
        }
    }
}
