using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alger.Utils.Collections
{
    public class MyList<T>:List<T>
    {
        public override string ToString()
        {
            string s=string.Empty;
            Array.ForEach(this.ToArray(),i=>s+=i);
            return s;
        }
    }
}
