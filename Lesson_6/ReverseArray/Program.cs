namespace ReverseArray
{
    internal class Program
    {
    #region Task_2
        //Написати програму для інверсії масиву, тобто перевороту його у зворотному порядку.
        //В цьому завданні недостатньо просто вивести елементи масиву у зворотному порядку. 
        //Ідеально написати 2 способами (* вища оцінка буде) - через новий масив та переписавши значення заданного масиву.
        //{5, -9, 8, 7} => {7, 8, -9, 5}
    #endregion
    static void Main(string[] args)
        {
            int[] originalArray = new int[10];
            // Fill array with random numbers
            FillArray(originalArray);
            // Print full array with random numbers and his inversed version

            #region Variant with second array
            Console.WriteLine("Variant 1");
            Print(originalArray);
            Console.Write("=> "); // separator
            Print(SecondArray(originalArray));
            #endregion
            #region Variant with inverse array
            Console.WriteLine("\nVariant 2");
            Print(originalArray);
            Console.Write("=> "); // separator
            Print(InverseArray(originalArray));
            #endregion
            #region The simplest variant via Reverse method of array class)))
            // Here will be reverse for already reversed array in Variant 2
            Console.WriteLine("\nVariant 3");
            Print(originalArray);
            Console.Write("=> "); // separator
            Print(ReverseArray(originalArray));
            #endregion
        }
        private static int GenerateRandomNumber(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }
        private static int[] FillArray(int[] originalArray)
        {

            for (int i = 0; i < originalArray.Length; i++)
            {
                int number = GenerateRandomNumber(-100, 101);
                originalArray[i] = number; // set
            }
            return originalArray;
        }
        private static void Print(int[] originalArray)
        {
            
            foreach (int number in originalArray)
            {
                Console.Write(number + " ");
            }
            
        }

        private static int[] SecondArray(int[] originalArray)
        {
            int[] secondArray = new int[originalArray.Length];
            for (int i = 0 ; i < originalArray.Length; i++)
            {
                secondArray[i] = originalArray[originalArray.Length - i-1];
               
            }
            return secondArray;
        }
        private static int[] InverseArray(int[] originalArray)
        {
            int buffer;
            for (int i = 0; i < originalArray.Length / 2; i++)
            {
                buffer = originalArray[originalArray.Length - i -1];
                originalArray[originalArray.Length - i - 1] = originalArray[i];
                originalArray[i] = buffer;
            }

            return originalArray;
        }
        private static int[] ReverseArray(int[] originalArray)
        {
            Array.Reverse(originalArray);
            return originalArray;
        }

    }
}
