using System.Text;

namespace CreaturesOfTheCode
{
    public class MythicalCreaturesHub
    {
        public MythicalCreaturesHub(int capacity)
        {
            Capacity = capacity;
            Creatures = new();
        }

        public List<Creature> Creatures { get; set; }
        public int Capacity { get; set; }

        public void AddCreature(Creature creature)
        {
            if (Creatures.Count < Capacity)
            {
                if (!Creatures.Any(c => c.Name.ToLower() == creature.Name.ToLower()))
                {
                    Creatures.Add(creature);
                }

            }
        }

        public bool RemoveCreature(string name)
        {
            return Creatures.Remove(Creatures.FirstOrDefault(c => c.Name == name));
        }

        public Creature GetStrongestCreature()
        {
            return Creatures.OrderByDescending(c => c.Health).FirstOrDefault();
        }

        public string Details(string creatureName)
        {
            Creature creature = Creatures.FirstOrDefault(c => c.Name == creatureName);

            if (creature == null)
            {
                return $"Creature with the name {creatureName} not found.";
            }
            return creature.ToString();
        }

        public string GetAllCreatures()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Mythical Creatures:");

            foreach (Creature creature in Creatures.OrderBy(c => c.Name))
            {
                sb.AppendLine($"{creature.Name} -> {creature.Kind}");
            }

            return sb.ToString().Trim();
        }
    }
}
