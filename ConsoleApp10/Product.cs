using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal abstract class Product
    {
        public string Name { get; set; }
        public double Price;


        public Product(string name,double price)
        {
            Name = name;
            Price = price;
        }

        public void GetInfo()
        {

            Console.WriteLine($"Ad:{Name} Qiymet:{Price}");
            
        }


    }
}
