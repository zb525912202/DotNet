using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericDemo
{
    public class SortHelper<T> where T : IComparable
    {
        public void BubbleSort(T[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = length - 1; j >0; j--)
                {
                    if (array[j].CompareTo(array[j - 1]) < 0)
                    {
                        T temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
        }
    }
}
