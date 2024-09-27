namespace PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new();
            {
                while (true)
                {
                    string input = Console.ReadLine();
                    if (input == "Tournament")
                    {
                        break;
                    }
                    string[] line = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string trainerName = line[0];
                    string pokemonName = line[1];
                    string pokemonElement = line[2];
                    int pokemonHealth = int.Parse(line[3]);

                    Trainer[] match = trainers.Where(tr => tr.Name == trainerName).ToArray();
                    Trainer currentTrainer;

                    if (match.Length == 0)
                    {
                        currentTrainer = new Trainer(trainerName);
                        trainers.Add(currentTrainer);
                    }
                    else
                    {
                        currentTrainer = match[0];
                    }
                    currentTrainer.Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                }
                while (true)
                {
                    string line = Console.ReadLine();
                    if (line == "End")
                    {
                        break;
                    }

                    foreach (Trainer trainer in trainers)
                    {
                        bool hasPokemonWithSameElement = false;

                        foreach (Pokemon pokemon in trainer.Pokemons)
                        {
                            if (pokemon.Element == line)
                            {
                                hasPokemonWithSameElement = true;
                            }
                        }
                        if (hasPokemonWithSameElement)
                        {
                            trainer.NumberOfBadges++;
                        }
                        else
                        {
                            List<Pokemon> alivePokemons = new();
                            foreach (Pokemon pokemon in trainer.Pokemons)
                            {
                                pokemon.Health -= 10;
                                if (pokemon.Health > 0)
                                {
                                    alivePokemons.Add(pokemon);
                                }
                            }
                            trainer.Pokemons = alivePokemons.ToList();
                        }
                    }
                }
                Trainer[] sorted = trainers.OrderByDescending(tr => tr.NumberOfBadges).ToArray();

                foreach(Trainer trainer in sorted)
                {
                    Console.WriteLine(trainer);
                }
            }
        }
    }
}