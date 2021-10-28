using ConsoleClient.Infrastructure;

namespace ConsoleClient.App
{
    public interface IExampleKata : IRunKata<string> {}
    
    public class ExampleKata : IExampleKata
    {
        private readonly IExampleDependency _exampleDependency;

        public ExampleKata(IExampleDependency exampleDependency)
        {
            _exampleDependency = exampleDependency;
        }
        
        public string Start()
        {
            return _exampleDependency.GetMessage();
        }
    }
}