namespace CustomStack;
public class Program
{
    static void Main(string[] args)
    {
        CustomStack<string> items = new CustomStack<string>();

        string[] valuesToPush = Console.ReadLine().Split(" ", 
            StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();
        
        for (int i = 0; i < valuesToPush.Length; i++)
        {
            valuesToPush[i] = valuesToPush[i].Replace(',', ' ');
            valuesToPush[i] = valuesToPush[i].Trim();
        }
        

        foreach (string value in valuesToPush)
        {
            items.Push(value);
        }

        while (true)
        {
            string command = Console.ReadLine();

            if (command == "END")
            {
                break;
            }
            else if (command == "Pop")
            {
                try
                {
                    items.Pop();
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("No elements");
                }

                
            }
            else
            {
                string[] split = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                items.Push(split[1]);
            }
        }
        for (int i = 0; i < 2; i++)
        {
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}