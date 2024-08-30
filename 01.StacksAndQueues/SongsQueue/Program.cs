
using System.Text;

Queue<string> playlist = new Queue<string>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries));

while (true)
{
    if (playlist.Count <= 0)
    {
        Console.WriteLine("No more songs!");
        break;
    }
    string[] command = Console.ReadLine().Split();
    switch (command[0])
    {
        default:
            break;

        case "Play":
            playlist.Dequeue();
            break;

        case "Add":
            StringBuilder song = new StringBuilder();
            for (int i = 1; i < command.Length; i++)
            {
                song.Append(command[i]);
                if (i < command.Length - 1)
                {
                    song.Append(" ");
                }
            }
            string songToString = song.ToString();
            if (!playlist.Contains(songToString))
            {
                playlist.Enqueue(songToString);
            }
            else
            {
                Console.WriteLine($"{song} is already contained!");
            }
            break;

        case "Show":
            Console.WriteLine(string.Join(", ", playlist));
            break;
    }
}