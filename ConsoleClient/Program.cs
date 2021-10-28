using System;
using ConsoleClient.App;
using ConsoleClient.Infrastructure.IoC;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONSOLE RUNNER IS GO!");
            
            var kata = DependencyResolver.Resolve<IExampleKata>();
            var result = kata.Start();
            Console.WriteLine(result);
        }
    }
}