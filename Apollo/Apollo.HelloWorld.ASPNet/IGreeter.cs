namespace Apollo.HelloWorld.ASPNet
{
    public interface IGreeter
    {
        string GetGreetingOfTheDay();
    }

    public class Greeter : IGreeter
    {
        public string GetGreetingOfTheDay()
        {
            return "Greeting";
        }
    }
}