using System.Text;

namespace CocktailBar
{
    public class Menu
    {
        public Menu(int barCapacity)
        {
            BarCapacity = barCapacity;
            Cocktails = new();
        }

        public List<Cocktail> Cocktails { get; set; }
        public int BarCapacity { get; set; }

        public void AddCocktail(Cocktail cocktail)
        {
            if (Cocktails.Count < BarCapacity)
            {
                if (Cocktails.FirstOrDefault(c => c.Name == cocktail.Name) == null)
                {
                    Cocktails.Add(cocktail);
                }
            }
        }
        public bool RemoveCocktail(string name)
        {
            return Cocktails.Remove(Cocktails.FirstOrDefault(c => c.Name == name));
        }
        public Cocktail GetMostDiverse()
        {
            return Cocktails.OrderByDescending(c => c.Ingredients.Count).FirstOrDefault();
        }
        public string Details(string cocktailName)
        {
            return Cocktails.FirstOrDefault(c => c.Name == cocktailName).ToString();
        }
        public string GetAll()
        {
            StringBuilder sb = new();
            sb.AppendLine("All Cocktails:");

            foreach (Cocktail cocktail in Cocktails.OrderBy(c => c.Name))
            {
                sb.AppendLine(cocktail.Name);
            }
            return sb.ToString().Trim();
        }
    }
}
