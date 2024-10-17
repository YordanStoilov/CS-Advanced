using System.Text;

namespace DataCenter
{
    public class Rack
    {
        public Rack(int slots)
        {
            Slots = slots;
            Servers = new();
        }

        public int Slots { get; set; }
        public List<Server> Servers { get; set; }
        public int GetCount { get => Servers.Count; }

        public void AddServer(Server server)
        {
            if (GetCount < Slots)
            {
                if (Servers.FirstOrDefault(s => s.SerialNumber == server.SerialNumber) == null)
                {
                    Servers.Add(server);
                }
            }
        }
        public bool RemoveServer(string serialNumber)
        {
            return Servers.Remove(Servers.FirstOrDefault(s => s.SerialNumber == serialNumber));
        }
        public string GetHighestPowerUsage()
        {
            return Servers.OrderByDescending(s => s.PowerUsage).FirstOrDefault().ToString();
        }
        public int GetTotalCapacity()
        {
            return Servers.Sum(s => s.Capacity);
        }
        public string DeviceManager()
        {
            StringBuilder sb = new();

            sb.AppendLine($"{GetCount} servers operating:");

            foreach (Server server in Servers)
            {
                sb.AppendLine(server.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
