namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of PluginManager
            PluginManager pluginManager = new PluginManager(); 

            // Create plugin instaces
            IPlugin calculatorPlugin = new CalculatorPlugin(5,10);
            IPlugin greetingPlugin = new GreetingPlugin();

            // Load plugin instaces
            pluginManager.LoadPlugin(calculatorPlugin);
            pluginManager.LoadPlugin(greetingPlugin);


            pluginManager.ExecuteAllPlugins();

        }
    }
}
