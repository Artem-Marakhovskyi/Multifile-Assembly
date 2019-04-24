using Navigation;
using System.Reflection;

[assembly:AssemblyVersion("1.2.3.9")]

namespace NavigationClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            System.Console.WriteLine(director.GetDirection());
            director.TurnLeft();
            director.TurnLeft();
            System.Console.WriteLine(director.GetDirection());
            director.TurnLeft();
            System.Console.WriteLine(director.GetDirection());
            director.TurnRight();
            director.TurnRight();
            director.TurnRight();
            director.TurnRight();
            System.Console.WriteLine(director.GetDirection());
            System.Console.ReadLine();
        }
    }
}
