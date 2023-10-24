using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714220052
{
    public class Product_714220052
    {
        protected String myType = "book";

        public Product_714220052()
        {

        }

        public string myType
        {
            get
            {
                return myType;
            }

            set
            {
                myType = value;
            }
        }
    }
}
