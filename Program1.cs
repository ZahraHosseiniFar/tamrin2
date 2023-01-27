using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program 
    {
        public static void Main(string[] args)
        {

            csl test = new csl();
            test.a =Convert.ToInt32(Console.ReadLine());
            test.b =Convert.ToInt32(Console.ReadLine());
            test.c =Convert.ToInt32(Console.ReadLine());
            test.d= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Convert.ToDouble(test.mlt()));
            Console.WriteLine(Convert.ToDouble(test.min()));
            Console.WriteLine(Convert.ToDouble(test.sum()));
            Console.ReadKey();
        }
    }
}
