using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Journal : Product
    {
        public string Company;
        public Journal(string name,double price,string company):base(name,price)
        {
            Company = company;
        }

        public void ShowAll() 
        {
            Console.WriteLine($"Ad:{Name} Qiymet:{Price} Sirket:{Company}");
        }
    }
}
