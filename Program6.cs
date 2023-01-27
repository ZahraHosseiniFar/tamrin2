using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = Convert.ToDouble(Console.ReadLine());
            Circle c = new Circle(r);
            Console.WriteLine(Convert.ToDouble(c.Masahat()));
            Console.WriteLine(Convert.ToDouble(c.Mohit()));
            Console.ReadKey();
        }
    }
}
