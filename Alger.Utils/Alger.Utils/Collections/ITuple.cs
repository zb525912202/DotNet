using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alger.Utils.Collections
{
    interface ITuple
    {
        int Size { get; }
        int GetHashCode(IEqualityComparer comparer);
        string ToString(StringBuilder sb);
    }
}
