﻿
using GenericBoxOfString;
namespace GenericBoxOfString
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                box.Add(Console.ReadLine());
            }
            Console.WriteLine(box);
        }
    }
}