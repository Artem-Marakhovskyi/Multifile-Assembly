using Navigation;

namespace NavigationClient
{
    class Client
    {
        static void Main(string[] args)
        {
            DirectionProvider d = new DirectionProvider();

            System.Console.WriteLine(d.GetDirection(0));
            System.Console.ReadLine();
        }
    }
}
