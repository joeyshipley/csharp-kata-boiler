namespace ConsoleClient.App
{
    public interface IExampleDependency
    {
        string GetMessage();
    }
    
    public class ExampleDependency : IExampleDependency
    {
        public string GetMessage()
        {
            return "NOM NOM NOM";
        }
    }
}