using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericDemo
{
    class Client
    {

        //static void Main(string[] args)
        //{
        //    SortHelper<int> isorter = new SortHelper<int>();
        //    int[] iar = { 1, 2, 8, 5, 9, 6 };
        //    isorter.BubbleSort(iar);
        //    foreach (var item in iar)
        //    {
        //        Console.Write(item + ",");
        //    }
        //    Console.ReadKey();
        //}

        //static void Main(string[] args)
        //{
        //    Book[] bookArray = new Book[2];
        //    Book book1 = new Book(100, "书一");
        //    Book book2 = new Book(80, "书二");
        //    bookArray[0] = book1;
        //    bookArray[1] = book2;

        //    Console.WriteLine("冒泡之前：");
        //    foreach (Book b in bookArray)
        //    {
        //        Console.WriteLine("书名：{0}，价格：{1}", b.Title, b.Price);
        //    }

        //    SortHelper<Book> sorter = new SortHelper<Book>();
        //    sorter.BubbleSort(bookArray);
        //    Console.WriteLine("冒泡之后：");
        //    foreach (Book b in bookArray)
        //    {
        //        Console.WriteLine("书名：{0}，价格：{1}", b.Title, b.Price);
        //    }
        //    Console.ReadKey();
        //}

        static void Main(string[] args)
        {

            Book[] bookArray = new Book[]{
            new Book(100, "书一"),
            new Book(80, "书二")
            };

            Console.WriteLine("冒泡之前：");
            foreach (Book b in bookArray)
            {
                Console.WriteLine("书名：{0}，价格：{1}", b.Title, b.Price);
            }

            MethodSortHelper sorter = new MethodSortHelper();
            sorter.BubbleSort(bookArray);
            Console.WriteLine("冒泡之后：");
            foreach (Book b in bookArray)
            {
                Console.WriteLine("书名：{0}，价格：{1}", b.Title, b.Price);
            }
            Console.ReadKey();
        }
    }
}
