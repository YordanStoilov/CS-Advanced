
List<string> people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
Dictionary<string, Func<string, bool>> predicates = new();
Action<List<string>> Print = ls => Console.WriteLine(string.Join(" ", ls));

string command;
while ((command = Console.ReadLine()) != "Print")
{
    string[] input = command.Split(";");
    string typeOperation = input[0], condition = input[1], numOrChar = input[2];
    Func<string, bool> predicate = str => true;

    if (condition == "Starts with")
    {
        predicate = str => str.StartsWith(numOrChar);
    }
    else if (condition == "Ends with")
    {
        predicate = str => str.EndsWith(numOrChar);
    }
    else if (condition == "Length")
    {
        predicate = str => str.Length == int.Parse(numOrChar);
    }
    else if (condition == "Contains")
    {
        predicate = str => str.Contains(numOrChar);
    }

    string newKey = condition + numOrChar;
    if (!predicates.ContainsKey(newKey))
    {
        predicates[newKey] = null;
    }

    if (typeOperation == "Add filter")
    {
        predicates[newKey] = predicate;
    }
    else if (typeOperation == "Remove filter")
    {
        predicates.Remove(condition + numOrChar);
    }
}
foreach (var kvp in predicates)
{
    Func<string, bool> predicate = kvp.Value;
    people = people.Where(person => !predicate(person)).ToList();
}
if (people.Count > 0)
{
    Print(people);
}