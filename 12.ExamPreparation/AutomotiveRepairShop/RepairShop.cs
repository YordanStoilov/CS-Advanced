﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotiveRepairShop;
public class RepairShop
{
    public RepairShop(int capacity)
    {
        Capacity = capacity;
        Vehicles = new List<Vehicle>();
    }

    public int Capacity { get; set; }
    public List<Vehicle> Vehicles { get; set; }

    public void AddVehicle(Vehicle vehicle)
    {
        if (Vehicles.Count < Capacity)
        {
            Vehicles.Add(vehicle);
        }
    }

    public bool RemoveVehicle(string vin)
    {
        Vehicle vehicle = Vehicles.FirstOrDefault(v => v.VIN == vin);
        
        return Vehicles.Remove(vehicle);
    }

    public int GetCount()
    {
        return Vehicles.Count;
    }

    public Vehicle GetLowestMileage()
    {
        return Vehicles.OrderBy(v => v.Mileage).FirstOrDefault();
    }

    public string Report()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Vehicles in the preparatory:");

        foreach (Vehicle vehicle in Vehicles)
        {
            sb.AppendLine(vehicle.ToString());
        }

        return sb.ToString().Trim();
    }
}
