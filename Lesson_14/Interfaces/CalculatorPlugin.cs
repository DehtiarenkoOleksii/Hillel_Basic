
namespace Interfaces
{
    /// <summary>
    /// Class with simple math operation
    /// </summary>
    public class CalculatorPlugin : IPlugin
    {

        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Sum { get;}

        public CalculatorPlugin(int number1, int number2)
        {
            Number1 = number1;
            Number2 = number2;
            Sum = Number1 + Number2;
        }

        void IPlugin.Execute()
        {
            Console.WriteLine($"CalculatorPlugin: The sum of {Number1} and {Number2} is {Sum}");
        }
    }
}
