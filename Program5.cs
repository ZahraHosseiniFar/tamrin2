using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car();
            Console.WriteLine(car1.HELLOUSER(" anashid "));
            car car2 = new car();
            Console.WriteLine(car2.HELLOUSER(" ana "));
            Console.ReadKey();
        }
    }
}
