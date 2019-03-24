using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_lesson1
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n;
            Console.WriteLine("Enter a number:");
           try
           {
            n = Convert.ToInt32(Console.ReadLine());
           }
           catch
           {
               Console.WriteLine("EROR");
           }
            n = Convert.ToInt32(Math.Pow(n,3));
            Console.WriteLine("Result: " + n);
            Console.ReadKey(true);
        }
    }
}
