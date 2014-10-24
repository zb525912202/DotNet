using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class TestClscs:IComparable
    {
        public TestClscs()
        {

        }
        private int _value;

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        /// 返回a和b的大小情况
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>1,0,-1</returns>
        public int CompareTo(object obj)
        {
            //使用as模式进行转型判断
            TestClscs aCls = obj as TestClscs;
            if (aCls != null)
                //实现抽象方法
                return _value.CompareTo(aCls._value);
            return -1;     
        }
    }
}
