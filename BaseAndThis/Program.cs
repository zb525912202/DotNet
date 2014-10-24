using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseAndThis
{
    class Program
    {
        static void Main(string[] args)
        {


        }



    }

    public class Action
    {
        public static void ToRun(Vehicle vehicle)
        {
            Console.WriteLine("{0} is running.", vehicle.ToString());
        }

        
        
    }

    public class Vehicle
    {
        private string name;
        private int speed;
        private string[] array = new string[10];

        public Vehicle()
        {
        }

        //限定被相似的名称隐藏的成员
        public Vehicle(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public virtual void ShowResult()
        {
            Console.WriteLine("The top speed of {0} is {1}.", name, speed);
        }

        public void Run()
        {
            //传递当前实例参数
            Action.ToRun(this);
        }



        //声明索引器，必须为this，这样就可以像数组一样来索引对象
        public string this[int param]
        {
            get { return array[param]; }
            set { array[param] = value; }
        }
    }

}
