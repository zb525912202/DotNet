using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace FrameworkDesign
{
    
    class Program
    {
        delegate void TestDelegate(string s);
        
        static void Main(string[] args)
        {
          
        TestDelegate myDel = n => { string s = n + " " + "World"; Console.WriteLine(s); };
        myDel("Hello");


        List<string> Citys = new List<string>() { 
          "BeiJing",
        "ShangHai",
        "Tianjin",
        "GuangDong"

        
        };
        
        ParameterExpression a = Expression.Parameter(typeof(int), "i");   //创建一个表达式树中的参数，作为一个节点，这里是最下层的节点


        }
    }
}
