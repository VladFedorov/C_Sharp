using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class
{
    public class Picture                       // описание класса Товар
    {
        public string Name;
        public string Author;
        public Picture(string name, string author)
        {
            this.Name = name;
            this.Author = author;
        }
        public void PrintName()
        {
            Console.WriteLine("Name:    " + this.Name);
        }
    }

    public class Painting : Picture                // Описание класса Продукт
    {
        public int Price;
        public Painting(string name, string author, int price)
            : base(name, author)
        {
            this.Price = price;
        }
        public void PrintPrice()
        {
            Console.WriteLine("Price:    " + this.Price);
        }
    }

    public class Remake : Painting        //описание класса Молочный продукт
    {
        public int Year;
        public Remake(string name,string author, int price, int year)
            : base(name, author, price)
        {
            if (year > 0 && year < 2020)
                this.Year = year;
            else
            {
                Console.WriteLine("Year set to 2019");
                this.Year = 2019;
            }
        }
        public void PrintGodnost()
        {
            Console.WriteLine("Year:    " + this.Year);
        }
    }

    public class Landscape : Remake            //описание класса Игрушка
    {
        public string strana;
        public Landscape(string name, string author, int price,int year, string strana)
            : base(name, author, price,year)
        {
            this.strana = strana;
        }
        public void PrintStrana()
        {
            Console.WriteLine("Place:    " + this.strana);
        }
    }

    class Program
    {
        delegate void Output();
        static void Main(string[] args)
        {
            Picture picture = new Picture("Batman","Tom");
            Painting painting = new Painting("Deamon Sitting","Michail Vrubel", 100000);
            Remake remake = new Remake("Sunflowers","Art-Holst", 200, 2019);
            Landscape landscape = new Landscape("Ninth Shaft","Ivan Ayvazovskiy", 100000, 1850, "Sea");
            Output output;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Info about PICTURE\n2.Info about PAINTING\n3.Info about REMAKE\n4.Info about LANDSCAPE");
                int selection = 0;
                try
                {
                   selection = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Unknown command");
                    Console.ReadKey();
                    continue;
                }
                switch (selection)
                {
                    case 1:
                        output = picture.PrintName;
                        output();
                        Console.ReadKey();
                        break;
                    case 2:
                        output = painting.PrintName;
                        output += painting.PrintPrice;
                        output();
                        Console.ReadKey();
                        break;
                    case 3:
                        output = remake.PrintName;
                        output += remake.PrintPrice;
                        output += remake.PrintGodnost;
                        output();
                        Console.ReadKey();
                        break;
                    case 4:
                        output = landscape.PrintName;
                        output += landscape.PrintPrice;
                        output += landscape.PrintGodnost;
                        output += landscape.PrintStrana;
                        output();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Unknown command");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}