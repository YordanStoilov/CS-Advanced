using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Car
    {
        public string Model { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }
        public Engine Engine { get; set; }

        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
            Weight = -1;
            Color = null;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Model}:");
            sb.AppendLine(Engine.ToString());

            if (Weight != -1)
            {
                sb.AppendLine($" Weight: {Weight}");
            }
            else
            {
                sb.AppendLine($" Weight: n/a");
            }
            if (Color != null)
            {
                sb.Append($" Color: {Color}");
            }
            else
            {
                sb.Append($" Color: n/a");
            }
            return sb.ToString();
        }
    }

}
