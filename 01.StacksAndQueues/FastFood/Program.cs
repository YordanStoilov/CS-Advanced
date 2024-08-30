
int ordersAvailable = int.Parse(Console.ReadLine());
Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

Console.WriteLine(orders.Max());

while (true)
{
    if (orders.Count <= 0)
    {
        Console.WriteLine("Orders complete");
        break;
    }
    int currentOrder = orders.Peek();
    if (currentOrder <= ordersAvailable)
    {
        orders.Dequeue();
        ordersAvailable -= currentOrder;
    }
    else
    {
        Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
        break;
    }
}