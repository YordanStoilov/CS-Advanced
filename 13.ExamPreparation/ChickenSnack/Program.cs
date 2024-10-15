

Stack<int> money = new Stack<int> (Console.ReadLine().Split(" ", 
    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Queue<int> prices = new Queue<int>(Console.ReadLine().Split(" ",
    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

int foodNecessary = 4;
int foodEaten = 0;

while (true)
{
    int cash = money.Pop();
    int price = prices.Dequeue();

    if (cash >= price)
    {
        foodEaten++;
        if (money.Count > 0)
        {
            int nextCash = money.Pop();
            money.Push(nextCash + (cash - price));
        }
        else
        {
            money.Push(cash - price);
        }
    }

    if (money.Count == 0 || prices.Count == 0)
    {
        break;
    }
}

if (foodEaten >= foodNecessary)
{
    Console.WriteLine($"Gluttony of the day! Henry ate {foodEaten} foods.");
}

else if (foodEaten > 0)
{
    string text = "food";
    if (foodEaten > 1) text += "s";

    Console.WriteLine($"Henry ate: {foodEaten} {text}.");
}
else
{
    Console.WriteLine("Henry remained hungry. He will try next weekend again.");
}