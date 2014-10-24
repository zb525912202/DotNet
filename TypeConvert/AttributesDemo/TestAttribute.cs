using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AttributesDemo
{
    class TestAttribute:Attribute
    {

        public TestAttribute(string message)
        {
            Console.WriteLine(message);
        }

        public void RunTest()
        {
            Console.WriteLine("TestAttribute here.");
        }
    }
}
