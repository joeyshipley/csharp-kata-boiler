namespace ConsoleClient.Infrastructure
{
    public interface IRunKata<T>
    {
        public T Start();
    }
}