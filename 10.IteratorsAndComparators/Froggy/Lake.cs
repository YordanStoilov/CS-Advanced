using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froggy;
public class Lake : IEnumerable
{
    public List<int> Numbers { get; set; }
    public int LastOddIndex { get; set; }
    public Lake(List<int> numbers)
    {
        Numbers = numbers;

        int lastOddIndex;
        if (Numbers.Count % 2 == 0)
        {
            lastOddIndex = Numbers.Count - 1;
        }
        else
        {
            lastOddIndex = Numbers.Count - 2;
        }
        LastOddIndex = lastOddIndex;    
    }

    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < Numbers.Count; i+= 2)
        {
            yield return Numbers[i];
        }
        for (int i = LastOddIndex; i >= 0; i -= 2)
        {
            yield return Numbers[i];
        }
    }
}
