using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            Person p1 = new Person();
            p1.name = "zahra";
            p1.family = "hosseini far";
            p1.age = 22;
            people.Add(p1);

            Person p2 = new Person();
            p2.name = "mehri";
            p2.family = "javan";
            p2.age = 38;
            people.Add(p2);

            foreach (Person p in people)
            {
                Console.WriteLine($"naame: {p.name} ,family: {p.family} ,age: {p.age}");
            }
            Console.ReadKey();
        }
    }
}
