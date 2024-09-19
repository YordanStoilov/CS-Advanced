﻿using CarManufacturer;
namespace CarManufacturer
{
    public class Tire
    {
        private int year;
        private double pressure;

        public int Year { get; set; }
        public double Pressure { get; set; }

        public Tire(int year, double pressure)
        {
            Pressure = pressure;
            Year = year;
        }
    }
}
