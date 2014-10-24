using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TupleDemo
{
    interface ITuple
    {
        int Size { get; }
        int GetHashCode(IEqualityComparer comparer);
        string ToString(StringBuilder sb);
    }
}
