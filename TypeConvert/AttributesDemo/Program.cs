using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace AttributesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //MessageBox(0, "How to use attribute in .NET", "Anytao_net", 0);

            Tester t = new Tester();
            t.CannotRun();

            Type tp = typeof(Tester);
            MethodInfo mInfo = tp.GetMethod("CannotRun");
            TestAttribute myAtt = (TestAttribute)Attribute.GetCustomAttribute(mInfo, typeof(TestAttribute));
            myAtt.RunTest();

            Console.ReadKey();

        }

        //[DllImport("User32.dll")]
        //public static extern int MessageBox(int hParent, string msg, string caption, int type);
       
    }

    class Tester
    {
         [Test("err")]
        public  void CannotRun()
        {
            Console.WriteLine("aaa");
        }
    }
}
