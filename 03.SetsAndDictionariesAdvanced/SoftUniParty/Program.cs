
Dictionary<string, HashSet<string>> invites = new();

bool IsValidInvitation(string invite)
{
    return invite.Length == 8;
}

string GetInviteType(string invite)
{
    if (char.IsNumber(invite[0]))
    {
        return "vip";
    }
    return "regular";
}

while (true)
{
    string currentInvite = Console.ReadLine();
    if (currentInvite.ToLower() == "party")
    {
        break;
    }
    if (IsValidInvitation(currentInvite))
    {
        string currentInviteType = GetInviteType(currentInvite);
        if (!invites.ContainsKey(currentInviteType))
        {
            invites[currentInviteType] = new HashSet<string>();
        }
        invites[currentInviteType].Add(currentInvite);
    }
}

while (true)
{
    string currentInvite = Console.ReadLine();
    if (currentInvite.ToLower() == "end")
    {
        break;
    }

    string inviteType = GetInviteType(currentInvite);
    if (invites[inviteType].Contains(currentInvite))
    {
        invites[inviteType].Remove(currentInvite);
    }
}
int noShowCount = 0;

foreach (var kvp in invites)
{
    noShowCount += kvp.Value.Count;
}
Console.WriteLine(noShowCount);

if (invites.ContainsKey("vip"))
{
    foreach (var invite in invites["vip"])
    {
        Console.WriteLine(invite);
    }
}
if (invites.ContainsKey("regular"))
{
    foreach (var invite in invites["regular"])
    {
        Console.WriteLine(invite);
    }
}
