﻿namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family newFamily = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = line[0];
                int age = int.Parse(line[1]);

                Person currentPersn = new Person(age, name);
                newFamily.AddMember(currentPersn);
            }
            Console.WriteLine(newFamily.GetOldestMember());
        }
    }
}