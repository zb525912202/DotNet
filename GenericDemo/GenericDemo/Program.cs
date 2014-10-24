using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericDemo
{
      using IntList = System.Collections.Generic.List<int>;

    class Program
    {
        static void Main(string[] args)
        {

            ArrayList list = new ArrayList();
            int i = 100;
            list.Add(i);
            string value = (string)list[0];
            
        }
    }


    class MyClass:IntList
    {
        
    }

  
  
   
    
}
