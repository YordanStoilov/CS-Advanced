using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threeuple;
internal class Threeuple<T1, T2, T3>
{
    public T1 FirstProperty { get; set; }
    public T2 SecondProperty { get; set; }
    public T3 ThirdProperty { get; set; }

    public Threeuple(T1 firstProperty, T2 secondProperty, T3 thirdProperty)
    {
        FirstProperty = firstProperty;
        SecondProperty = secondProperty;
        ThirdProperty = thirdProperty;
    }
    public override string ToString()
    {
        return $"{FirstProperty} -> {SecondProperty} -> {ThirdProperty}";
    }
}
