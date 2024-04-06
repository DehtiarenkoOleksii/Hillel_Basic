namespace Seconds_In_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort hours = 24;
            ushort minutes = 0;
            ushort seconds = 0;
            int secresult = (hours * 3600 + minutes * 60 + seconds);
            Console.WriteLine($"Time {hours}:{minutes}:{seconds} = {secresult} seconds");
            Console.ReadKey();
            
        }
    }
}
