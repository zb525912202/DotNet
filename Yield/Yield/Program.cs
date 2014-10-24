using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yield
{
    class Program
    {
        static Random r = new Random();
        static IEnumerable<int> GetList(int count)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < count; i++)
            {
                list.Add(r.Next(10));
            }
             return list;
        }

        static IEnumerable<int> GetListWidthYield(int count)
        {

            while (true)
            {
                int temp = r.Next(100);
                if (temp % 10 == 0)
                {
                    yield break;
                }
                yield return temp;
            }
            
           
        }
        static void Main(string[] args)
        {
            foreach (int item in GetListWidthYield(5))
                Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
