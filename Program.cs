using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter person number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Person[] w = new Person[number];
            int i;
            for(i=0 ; i <number; i++)
            {
                Console.WriteLine($"please enter person[{i+1}] name : ");
                string name = Console.ReadLine();

                Person p = new Person(name);
                w[i] = p;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (Person person in w)
            {
                Console.WriteLine($"name is : {person.name}");
            }
            Console.ResetColor();
            Console.ReadKey();
        }

    }
}
