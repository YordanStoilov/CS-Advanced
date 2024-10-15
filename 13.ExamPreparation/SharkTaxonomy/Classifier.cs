using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharkTaxonomy;
public class Classifier
{
    public Classifier(int capacity)
    {
        Capacity = capacity;
        Species = new();
    }

    public int Capacity { get; set; }
    public List<Shark> Species { get; set; }
    public int GetCount { get
        {
            return Species.Count;
        } 
    }

    public void AddShark(Shark shark)
    {
        if (Species.Count >= Capacity)
        {
            return;
        }
        if (Species.Contains(shark))
        {
            return;
        }
        Species.Add(shark);
    }

    public bool RemoveShark(string kind)
    {
        Shark? foundShark = Species.FirstOrDefault(s => s.Kind == kind);
        return Species.Remove(foundShark);
    }

    public string GetLargestShark()
    {
        Shark? biggestShark = Species.OrderByDescending(s => s.Length).FirstOrDefault();
        return biggestShark.ToString();
    }
    public double GetAverageLength()
    {
        return (double)Species.Average(s => s.Length);
    }

    public string Report()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{Species.Count} sharks classified:");

        foreach(Shark shark in Species)
        {
            sb.AppendLine(shark.ToString());
        }
        return sb.ToString().Trim();
    }
}
