using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin
{
    class Form
    {
        private string name ;
        private string family ;
        private int id;
        private int time;
        private double  pay;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Family
        {
            get { return family; }
            set { family = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Time
        {
            get { return time; }
            set { time = value; }
        }
        public double  Pay
        {
            get { return pay; }
            set { pay = value; }
        }


        public Form() { }
        public Form (string a , string b , int c , int d  , double  e)
        {
            name = a;
            family = b;
            id = c;
            time = d;
            pay = e;
        }
        public void workre()
        {
            Console.WriteLine($"NAME : {name } FAMILY : {Family} ID : {id } TIME : {time } PAY : {pay}") ;
        }
        public double payment()
        {
            return (time * pay);
        }
    }
}
