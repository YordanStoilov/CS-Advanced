using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency;
public class EstateAgency
{
    public EstateAgency(int capacity)
    {
        Capacity = capacity;
        RealEstates = new();
    }

    public int Capacity { get; set; }
    public List<RealEstate> RealEstates { get; set; }
    public int Count
    {
        get
        {
            return RealEstates.Count;
        }
    }
    public void AddRealEstate(RealEstate realEstate)
    {
        if (RealEstates.Count < Capacity)
        {
            if (RealEstates.FirstOrDefault(e => e.Address == realEstate.Address) == default)
            {
                RealEstates.Add(realEstate);
            }
        }
    }
    public bool RemoveRealEstate(string address)
    {
        return RealEstates.Remove(RealEstates.FirstOrDefault(e => e.Address == address));
    }
    public List<RealEstate> GetRealEstates(string postalCode)
    {
        return RealEstates.Where(e => e.PostalCode == postalCode).ToList();
    }
    public RealEstate GetCheapest()
    {
        return RealEstates.OrderBy(e => e.Price).FirstOrDefault();
    }
    public double GetLargest()
    {
        return RealEstates.OrderByDescending(e => e.Size).FirstOrDefault().Size;
    }
    public string EstateReport()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Real estates available:");

        foreach (RealEstate estate in RealEstates)
        {
            sb.AppendLine(estate.ToString());
        }

        return sb.ToString().Trim();
    }
}
