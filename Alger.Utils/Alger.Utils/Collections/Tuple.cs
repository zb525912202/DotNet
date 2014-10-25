using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alger.Utils.Collections
{
    public class Tuple<T1, T2, T3> : ITuple
    {
        private readonly T1 m_Item1;
        private readonly T2 m_Item2;
        private readonly T3 m_Item3;

        public T1 Item1
        {

            get
            {
                return this.m_Item1;
            }
        }
        public T2 Item2
        {

            get
            {
                return this.m_Item2;
            }
        }
        public T3 Item3
        {

            get
            {
                return this.m_Item3;
            }
        }
        int ITuple.Size
        {
            get
            {
                return 3;
            }
        }

        public Tuple(T1 item1, T2 item2, T3 item3)
        {
            this.m_Item1 = item1;
            this.m_Item2 = item2;
            this.m_Item3 = item3;
        }

        public override int GetHashCode()
        {
            return 0;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("(");
            return ((ITuple)this).ToString(stringBuilder);
        }
        string ITuple.ToString(StringBuilder sb)
        {
            sb.Append(this.m_Item1);
            sb.Append(", ");
            sb.Append(this.m_Item2);
            sb.Append(", ");
            sb.Append(this.m_Item3);
            sb.Append(")");
            return sb.ToString();
        }

        public int GetHashCode(System.Collections.IEqualityComparer comparer)
        {
            throw new NotImplementedException();
        }
    }

    public class Tuple
    {
        public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
        {
            return new Tuple<T1, T2, T3>(item1, item2, item3);
        }

    }
}
