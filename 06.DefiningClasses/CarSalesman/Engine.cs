using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
            Displacement = -1;
            Efficiency = null;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Model}:");
            sb.AppendLine($"  Power: {Power}");
            
            if (Displacement != -1)
            {
                sb.AppendLine($"  Displacement: {Displacement}");
            }
            else
            {
                sb.AppendLine("  Displacement: n/a");
            }
            if (Efficiency != null)
            {
                sb.Append($"  Efficiency: {Efficiency}");
            }
            else
            {
                sb.Append("  Efficiency: n/a");
            }
            return sb.ToString();
        }
    }
}
