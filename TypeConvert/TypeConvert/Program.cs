using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypeConvert
{
    class Program
    {
        static void Main(string[] args)
        {

            //Object o = new object();
            //Type t = o.GetType();
            //Console.WriteLine(t);

            object o = new object();
            //A a = (A)o;
            if (o is A)
            {
                A a = (A)o;
            }


            if (o as B!=null)
            {
                A a = (A)o;
            }


            Console.ReadKey();
        }
        class A
        {

        }
        class B
        {

        }
    }
}
