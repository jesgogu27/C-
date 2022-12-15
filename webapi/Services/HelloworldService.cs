
public class HelloworldService : IHelloworldService
    {
        public string GetHelloWorld()
        {
            return "Hello World";
        }
        
    }

public interface IHelloworldService
{
    string GetHelloWorld();
}