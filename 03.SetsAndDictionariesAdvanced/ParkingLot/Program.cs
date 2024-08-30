
HashSet<string> parkingLot = new();

while (true)
{
    string[] input = Console.ReadLine().Split(", ");
    if (input[0].ToLower() == "end")
    {
        break;
    }
    string direction = input[0], licensePlate = input[1];
    if (direction.ToLower() == "in")
    {
        parkingLot.Add(licensePlate);
    }
    else
    {
        if (parkingLot.Contains(licensePlate))
        {
            parkingLot.Remove(licensePlate);
        }
    }
}
if (parkingLot.Count <= 0)
{
    Console.WriteLine("Parking Lot is Empty");
}
else
{
    foreach (string plate in parkingLot)
    {
        Console.WriteLine(plate);
    }
}
