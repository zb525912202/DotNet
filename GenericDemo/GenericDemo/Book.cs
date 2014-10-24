using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericDemo
{
    class Book:IComparable
    {

        private int price;

        public int Price
        {
            get { return price; }
           
        }
        private string title;

        public string Title
        {
            get { return title; }
         
        }

        public Book()
        {

        }
        public Book(int price,string Title)
        {
            this.price = price;
            this.title = title;
        }




        public int CompareTo(object obj)
        {
            Book book = (Book)obj;
            return this.Price.CompareTo(book.Price);
        }
    }
}
