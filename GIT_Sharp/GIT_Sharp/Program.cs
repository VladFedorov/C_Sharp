using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Math.Pow(n,3));
            Console.WriteLine("Result: " + n);
            Console.ReadKey(true);
        }
    }
}
