using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MateriOOP
{
    internal class FieldProperty
    {
    }
}


public class PropertyTest
{
    private string materi;

    public string Materi
    {
        get { return materi; }
        set { materi = value; }
    }

    public class person
    {
        private int nilai = 0;

        public int Nilai
        {
            get { return nilai; }
            set
            {
                if (value > 50) 
                nilai = value;
            }
        }
    }
}

