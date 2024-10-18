using System.Text;

namespace GroceriesManagement
{
    public class GroceriesStore
    {
        public GroceriesStore(int capacity)
        {
            Capacity = capacity;
            Turnover = 0;
            Stall = new();
        }

        public int Capacity { get; set; }
        public double Turnover { get; set; }
        public List<Product> Stall { get; set; }
        public void AddProduct(Product product)
        {
            if (Stall.Count < Capacity)
            {
                if (Stall.FirstOrDefault(p => p.Name == product.Name) == null)
                {
                    Stall.Add(product);
                }
            }
        }
        public bool RemoveProduct(string name)
        {
            return Stall.Remove(Stall.FirstOrDefault(p => p.Name == name));
        }
        public string SellProduct(string name, double quantity)
        {
            Product product = Stall.FirstOrDefault(p => p.Name == name);
            if (product == null)
            {
                return "Product not found";
            }
            string str = $"{quantity * product.Price:F2}";
            Turnover += double.Parse(str);
            return $"{product.Name} - {str}$";
        }
        public string GetMostExpensive()
        {
            return Stall.OrderByDescending(p => p.Price).FirstOrDefault().ToString();
        }
        public string CashReport()
        {
            return $"Total Turnover: {Turnover:F2}$";
        }
        public string PriceList()
        {
            StringBuilder sb = new();

            sb.AppendLine("Groceries Price List:");

            foreach (Product product in Stall)
            {
                sb.AppendLine(product.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
