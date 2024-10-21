using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Library
    {
        public Book[] mehsullar;

        public Library()
        {
            mehsullar = new Book[0];
        }


        public void Add(Book mehsul)
        {
            Array.Resize(ref mehsullar, mehsullar.Length + 1);
            mehsullar[mehsullar.Length - 1] = mehsul;
        }

        public void GetPrice(int min, int max)
        {
            for (int i = 0; i < mehsullar.Length; i++)
            {
                if (mehsullar[i].Price <= max && mehsullar[i].Price >= min)
                {
                    Console.WriteLine(mehsullar[i].Name);
                    Console.WriteLine(mehsullar[i].Price);
                    Console.WriteLine(mehsullar[i].Author);
                    Console.WriteLine(mehsullar[i].Genre);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Bu araliqda mehsul tapilmadi");
                }
            }

        }

        public void Search (string name)
        {
            for (int i = 0; i < mehsullar.Length; i++)
            {
                if (mehsullar[i].Name==name)
                {
                    Console.WriteLine("Kitab adi:" + mehsullar[i].Name);
                    Console.WriteLine("Kitab qiymeti:" + mehsullar[i].Price);
                    Console.WriteLine("Kitab muellifi:" + mehsullar[i].Author);
                    Console.WriteLine("Kitab Janri:" + mehsullar[i].Genre);
                    Console.WriteLine();
                }
                
                
            }
        }

        public void ShowAll()
        {
            for(int i = 0;i < mehsullar.Length;i++)
            {
                Console.WriteLine("Kitab adi:"+mehsullar[i].Name);
                Console.WriteLine("Kitab qiymeti:"+mehsullar[i].Price);
                Console.WriteLine("Kitab muellifi:"+mehsullar[i].Author);
                Console.WriteLine("Kitab Janri:"+mehsullar[i].Genre);
                Console.WriteLine();
            }
        }
    }
}
