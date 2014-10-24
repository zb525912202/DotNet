using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            TestClscs t = new TestClscs();
            t.Value = 10;

            TestClscs t1 = new TestClscs();
            t1.Value = 9;

           int res = t.CompareTo(t1);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
