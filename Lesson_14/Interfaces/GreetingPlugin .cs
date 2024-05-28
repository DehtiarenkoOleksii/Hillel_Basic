
namespace Interfaces
{

    /// <summary>
    /// Class with greeting message
    /// </summary>
    public class GreetingPlugin : IPlugin
    {
        public void  Execute()
        {
            Console.WriteLine("GreetingPlugin: Hello, I'm your plugin! Let's be friends!");
        }
    }
}
