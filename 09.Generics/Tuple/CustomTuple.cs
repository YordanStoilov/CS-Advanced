using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple;
public class CustomTuple<T1, T2>
{
    public T1 FirstProperty { get; set; }
    public T2 SecondProperty { get; set; }

    public CustomTuple(T1 firstProperty, T2 secondProperty)
    {
        FirstProperty = firstProperty;
        SecondProperty = secondProperty;
    }
    public override string ToString()
    {
        return $"{FirstProperty} -> {SecondProperty}";
    }
}
