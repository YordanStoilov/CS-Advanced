namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person(20);
            Person person3 = new Person(30, "Yordan");
            Console.WriteLine(person1.Name);
            Console.WriteLine(person1.Age);
            Console.WriteLine();
            Console.WriteLine(person2.Name);
            Console.WriteLine(person2.Age);
            Console.WriteLine();
            Console.WriteLine(person3.Name);
            Console.WriteLine(person3.Age);
        }
    }
}