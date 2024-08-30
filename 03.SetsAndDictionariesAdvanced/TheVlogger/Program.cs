
HashSet<Vlogger> vloggers = new HashSet<Vlogger>();

string[] command;
while ((command = Console.ReadLine().Split())[0] != "Statistics")
{
    string firstVlogger = command[0], action = command[1];
    if (action == "joined" && !vloggers.Contains(FindVloggerByName(firstVlogger)))
    {
        vloggers.Add(new Vlogger(firstVlogger));
    }
    else if (action == "followed")
    {
        string secondVlogger = command[2];
        if (firstVlogger == secondVlogger)
        {
            continue;
        }
        if (!UserExists(firstVlogger) || !UserExists(secondVlogger))
        {
            continue;
        }
        Vlogger currentVlogger = FindVloggerByName(firstVlogger);
        Vlogger beingFollowed = FindVloggerByName(secondVlogger);
        if (currentVlogger == null || beingFollowed == null)
        {
            continue;
        }
        if (currentVlogger.Following.Contains(beingFollowed))
        {
            continue;
        }
        currentVlogger.Following.Add(beingFollowed);
        beingFollowed.Followers.Add(currentVlogger);
    }
}

List<Vlogger> sorted = vloggers
.OrderByDescending(vlogger => vlogger.Followers.Count)
.ThenBy(vlogger => vlogger.Following.Count).ToList();

Console.WriteLine($"The V-Logger has a total of {sorted.Count} vloggers in its logs.");

int count = 1;
foreach (Vlogger vlogger in sorted)
{
    Console.WriteLine($"{count}. {vlogger.Name} : {vlogger.Followers.Count} followers, {vlogger.Following.Count} following");
    if (count == 1)
    {
        foreach (Vlogger follower in vlogger.Followers)
        {
            Console.WriteLine($"*  {follower.Name}");
        }
    }
    count++;
}

bool UserExists(string name)
{
    foreach (Vlogger vlogger in vloggers)
    {
        if (vlogger.Name == name)
        {
            return true;
        }
    }
    return false;
}

Vlogger FindVloggerByName(string name)
{
    foreach (Vlogger vlogger in vloggers)
    {
        if (vlogger.Name == name)
        {
            return vlogger;
        }
    }
    return null;
}

class Vlogger : IComparable<Vlogger>
{
    public string Name { get; set; }
    public HashSet<Vlogger> Following { get; set; }
    public SortedSet<Vlogger> Followers { get; set; }
    public Vlogger(string name)
    {
        Name = name;
        Following = new HashSet<Vlogger>();
        Followers = new SortedSet<Vlogger>();
    }
    public int CompareTo(Vlogger other)
    {
        if (other == null) return 1;

        return string.Compare(this.Name, other.Name, StringComparison.Ordinal);
    }
    public override bool Equals(object obj)
    {
        if (obj is Vlogger other)
        {
            return Name.Equals(other.Name, StringComparison.Ordinal);
        }
        return false;
    }
}