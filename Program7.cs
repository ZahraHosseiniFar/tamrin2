using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin
{
    class Program
    {
        static void Main(string[] args)
        { 
            Form  A = new Form();
            A.Name = "ZAHRA  ";
            A.Family = "HOSSEINIFAR  ";
            A.Id = 123456789  ;
            A.Time = 8  ;
            A.Pay = 50000  ;
            A.workre();
            Console.WriteLine(Convert.ToString(A.payment()));
            Console.ReadKey();
        }
    }
}
