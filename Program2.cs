using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        private int R_max;
        private int R_min;

        public int r_max
        {
            get { return R_max; }
            set { R_max = value; }
        }
        public int r_min
        {
            get { return R_min; }
            set { R_min = value; }
        }
        public void cal() { }
        public void cal(int a, int b)
        {
            R_max = a;
            R_min = b;
        }
        public double masahat()
        {
            double x = R_max * R_min * 3.14;
            return x;
        }
    }
        class cls
        {
            public static void main()
            {
                Program test = new Program();
                double result = test.masahat();
                Console.WriteLine(result);
            }
        }
}
