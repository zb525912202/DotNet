using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    public abstract class Animal
    {
        //定义静态字段
        protected int _id;

        //定义属性
        public abstract int Id
        {
            get;
            set;
        } 

         //定义方法
        public abstract  void Eat();
    
        //定义索引器
        public abstract string this[int i]
        {
            get;
            set;
        } 
 
    }


    /// <summary>
    /// 实现抽象类
    /// </summary>
    public class Dog : Animal
    {
        public override int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public override void Eat()
        {
            Console.Write("Dog Eats.");
        }

        public override string this[int i]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

    }


 
   
}
