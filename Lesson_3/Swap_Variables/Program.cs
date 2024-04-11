namespace Swap_Variables
{
    internal class Program
    {
        //Дослідити інші способи поміняти місцями значення двох змінних без використання тимчасової змінної та використання суми/множення.
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, num5, num6, num7, num8, num9, num10;
            Console.Write("Enter num1: ");
            string? input1 = Console.ReadLine();
            Console.Write("Enter num2: ");
            string? input2 = Console.ReadLine();
            num1 = int.Parse(input1);
            num2 = int.Parse(input2);
            num3 = int.Parse(input1);
            num4 = int.Parse(input2);
            num5 = int.Parse(input1);
            num6 = int.Parse(input2);
            num7 = int.Parse(input1);
            num8 = int.Parse(input2);
            num9 = int.Parse(input1);
            num10 = int.Parse(input2);


            // Variant_1 Turples
            (num1, num2) = (num2, num1);
            Console.WriteLine("\nVariant_1");
            Console.WriteLine($"num1 = {num1}");
            Console.WriteLine($"num2 = {num2}");

            // Variant_2 Using method
            SwapingDigits (ref num3, ref num4);
            Console.WriteLine("\nVariant_2");
            Console.WriteLine($"num1 = {num3}");
            Console.WriteLine($"num2 = {num4}");
            

            // Variant_3 Insidious deception of the user )))
            Console.WriteLine("\nVariant_3");
            Console.WriteLine($"num1 = {num6}");
            Console.WriteLine($"num2 = {num5}");

            // Variant_4 Using method with XOR (added for my memory)
            XorSwap(ref num7, ref num8);
            Console.WriteLine("\nVariant_4");
            Console.WriteLine($"num1 = {num7}");
            Console.WriteLine($"num2 = {num8}");

            // Variant_5 Bit Reverse
            BitwiseComplement(ref num9, ref num10);
            Console.WriteLine("\nVariant_5");                     
            Console.WriteLine($"num1 = {num9}");
            Console.WriteLine($"num2 = {num10}");

            //Delay
            Console.ReadKey();
        }
        static void SwapingDigits(ref int num3, ref int num4)
        {
            num3 = num3 + num4;
            num4 = num3 - num4;
            num3 = num3 - num4; 

        }
        static void XorSwap(ref int num7, ref int num8)
        {
            num7 = num7 ^ num8;
            num8 = num8 ^ num7;
            num7 = num7 ^ num8;

        }
        static void BitwiseComplement (ref int num9, ref int num10)
        {
            //  num9 = 2 in binary  00000000 00000000 00000000 00000010 -> 0..00000010     num10 = 3 in binary 00000000 00000000 00000000 00000011 -> 0..00000011

            num9 = num10 - ~num9 - 1;  // 3 - (0..00000010 (2) -> 1..11111101 (-3)) - 1 == 3 - (-3) - 1 == 3+3-1 == 5
            num10 = num9 + ~num10 + 1; // 5 + (0..00000011 (3) -> 1..11111100 (-4)) + 1 == 5 + (-4) + 1 == 5-4+1 == 2
            num9 = num9 + ~num10 + 1;  // 5 + (0..00000010 (2) -> 1..11111101 (-3)) + 1 == 5 + (-3) + 1 == 5-3+1 == 3
        }
    }
}
