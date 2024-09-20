namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person newPerson = new Person();
            newPerson.Age = 29;
            newPerson.Name = "Test";
            Console.WriteLine(newPerson.Age);
            Console.WriteLine(newPerson.Name);
        }
    }
}