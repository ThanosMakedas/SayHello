namespace SayHello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHello("World");
            Console.ReadLine();
        }

        static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
