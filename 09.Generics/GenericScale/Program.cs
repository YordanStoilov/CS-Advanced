
namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> equality = new EqualityScale<int>('c', 'v');

            Console.WriteLine(equality.AreEqual());
        }
    }
}