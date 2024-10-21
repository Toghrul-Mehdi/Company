namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool f = false;
            Library library = new Library();

            do
            {

                Console.WriteLine("1.AddProduct    2.ShowAll    3.PriceFilter    4.Search    0.Exit");

                string Secim = Console.ReadLine();

                


                switch (Secim)
                {
                    case "1":
                        Console.WriteLine("Mehsul adi daxil edin:");
                        string Name = Console.ReadLine();
                        bool price_bool;
                        double Price;
                        do
                        {
                            Console.WriteLine("Qiymet daxil edin:");

                            price_bool = double.TryParse(Console.ReadLine(), out Price);

                            if (Price > 0)
                            {
                                price_bool = true;
                            }
                            else
                            {
                                price_bool = false;
                            }
                        } while (!price_bool);
                        Console.WriteLine("Muellif daxil edin:");
                        string author = Console.ReadLine();

                        Console.WriteLine("Janr daxil edin:");
                        string genre = Console.ReadLine();

                        Book kitab = new Book(Name, Price, author, genre);


                        library.Add(kitab);




                        break;
                    case "2":
                        Console.WriteLine("Butun mehsullar:");
                        library.ShowAll();
                        break;

                    case "3":

                        int minprice;
                        int maxprice;
                        bool boolmin;
                        bool boolmax;
                        do
                        {
                            Console.WriteLine("Min Price:");
                            boolmin = int.TryParse(Console.ReadLine(), out minprice);
                            if (minprice > 0)
                            {
                                boolmin = true;
                            }
                            else
                            {
                                boolmin = false;
                            }

                        } while (!boolmin);

                        do
                        {
                            Console.WriteLine("Max Price:");
                            boolmax = int.TryParse(Console.ReadLine(), out maxprice);
                            if (maxprice > minprice)
                            {
                                boolmax = true;
                            }
                            else
                            {
                                boolmax = false;
                            }
                        } while (!boolmax);

                        library.GetPrice(minprice, maxprice);



                        break;
                    case "4":
                        string user_data = Console.ReadLine();
                        library.Search(user_data);
                        break;
                    case "0":
                        return;
                    default:
                        break;
                }


            } while (!f);
        }
    }
}
