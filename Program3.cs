using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 pride = new Class1();
            pride.Speed = 490;
            Console.WriteLine($"carname is :{pride.carname}");
            Console.WriteLine ($"pride speed is :{ pride.Speed}");
            Console.ReadKey();
        }
    }
}
