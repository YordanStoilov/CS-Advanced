
Dictionary<string, string> courses = new();
HashSet<Contestant> contestants = new();

while (true)
{
    string input = Console.ReadLine();
    if (input == "end of contests")
    {
        break;
    }
    string[] command = input.Split(":");
    string courseName = command[0], password = command[1];
    if (!courses.ContainsKey(courseName))
    {
        courses[courseName] = password;
    }
}
while (true)
{
    string input = Console.ReadLine();
    if (input == "end of submissions")
    {
        break;
    }
    string[] command = input.Split("=>");
    string courseName = command[0], password = command[1], studentName = command[2];
    int studentScore = int.Parse(command[3]);

    if (!courses.ContainsKey(courseName))
    {
        continue;
    }
    if (courses[courseName] != password)
    {
        continue;
    }
    if (ContestantExists(studentName))
    {
        Contestant currentContestant = FindContestantByName(studentName);
        if (!currentContestant.Grades.ContainsKey(courseName))
        {
            currentContestant.Grades[courseName] = studentScore;
            currentContestant.TotalScore += studentScore;
        }
        int difference = studentScore - currentContestant.Grades[courseName];
        if (difference > 0)
        {
            currentContestant.Grades[courseName] = studentScore;
            currentContestant.TotalScore += difference;
        }
    }
    else
    {
        Contestant newContestant = new Contestant(studentName);
        newContestant.Grades[courseName] = studentScore;
        newContestant.TotalScore += studentScore;
        contestants.Add(newContestant);
    }
}

Contestant highestGradedContestant = contestants.OrderByDescending(c => c.TotalScore).FirstOrDefault();
Console.WriteLine($"Best candidate is {highestGradedContestant.Name}"
+ $" with total {highestGradedContestant.TotalScore} points.\nRanking:");

HashSet<Contestant> sorted = contestants.OrderBy(c => c.Name).ToHashSet();

foreach (Contestant contestant in sorted)
{
    Console.WriteLine($"{contestant.Name}");
    foreach (var kvp in contestant.Grades
    .OrderByDescending(kvp => kvp.Value))
    {
        Console.WriteLine($"#  {kvp.Key} -> {kvp.Value}");
    }
}

bool ContestantExists(string name)
{
    foreach (Contestant contestant in contestants)
    {
        if (contestant.Name == name)
        {
            return true;
        }
    }
    return false;
}

Contestant FindContestantByName(string name)
{
    foreach (Contestant contestant in contestants)
    {
        if (contestant.Name == name)
        {
            return contestant;
        }
    }
    return null;
}

class Contestant
{
    public string Name { get; set; }
    public Dictionary<string, int> Grades { get; set; }
    public int TotalScore { get; set; }
    public Contestant(string name)
    {
        Name = name;
        Grades = new();
        TotalScore = 0;
    }
}
