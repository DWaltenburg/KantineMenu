using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KantineMenu
{
    class Class1
    {
        public string name { get; set; }
        public string desc { get; set; }
        public float price { get; set; }

        public string Name { get { return name; } set { name = value; } } 
        public string Desc { get { return desc; } set { desc = value; } } 
        public float Price { get { return price; } set { price = value; } } 
    }
}