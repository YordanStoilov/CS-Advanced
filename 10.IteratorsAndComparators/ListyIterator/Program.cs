namespace ListyIterator;

public class Program
{
    static void Main(string[] args)
    {
        List<string> userInput = new();

        string[] createConditions = Console.ReadLine().Split(" ", 
            StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();

        foreach(string condition in createConditions)
        {
            userInput.Add(condition);
        }

        ListyIterator<string> listy = new ListyIterator<string>(userInput);
        
        while (true)
        {
            string command = Console.ReadLine();
            if (command == "END")
            {
                break;
            }
            
            switch (command)
            {
                default:
                    break;

                case "Print":
                    listy.Print();
                    break;
                case "Move":
                    Console.WriteLine(listy.Move());
                    break;
                case "HasNext":
                    Console.WriteLine(listy.HasNext());
                    break;
            }
        }
    }
}