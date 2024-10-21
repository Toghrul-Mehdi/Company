using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Book :Product
    {
        public string Author;
        public string Genre;

        

        public Book(string name,double price,string author,string genre):base(name,price)
        {
            Author = author;
            Genre = genre;
        }

        public void ShowAll()
        {
            Console.WriteLine($"Ad:{Name} Qiymet:{Price} Muellif:{Author} Janr:{Genre}");
        }
    }
}
