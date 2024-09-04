
Func<string, string, bool> StartsWith = (str, substr) => str.StartsWith(substr);
Func<string, string, bool> EndsWith = (str, substr) => str.EndsWith(substr);
Func<string, int, bool> LengthFilter = (str, filter) => str.Length == filter;

List<string> people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

string command;

while ((command = Console.ReadLine()) != "Party!")
{
    string[] input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string action = input[0], condition = input[1];
    List<string> filtered = new();

    if (condition == "StartsWith")
    {
        filtered = people
            .Where(person => StartsWith(person, input[2]))
                .ToList();
    }
    else if (condition == "Length")
    {
        filtered = people
            .Where(person => LengthFilter(person, int.Parse(input[2])))
                .ToList();
    }
    else if (condition == "EndsWith")
    {
        filtered = people
            .Where(person => EndsWith(person, input[2]))
                .ToList();
    }

    if (action == "Remove")
    {
        foreach (string person in filtered)
        {
            people.RemoveAll(name => name == person);
        }
    }
    else if (action == "Double")
    {
        foreach (string person in filtered)
        {
            int index = people.IndexOf(person);
            if (index > -1)
            {
                people.Insert(index, person);
            }
        }
    }
}
if (people.Count == 0)
{
    Console.WriteLine("Nobody is going to the party!");
}
else
{
    Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
}