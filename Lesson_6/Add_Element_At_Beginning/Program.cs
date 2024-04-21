namespace Add_Element_At_Beginning
{
    internal class Program
    #region Task_3
    //Потрібно додати до масиву елемент на початок.Нехай масив буде на 10 елементів.
    //Масив заповнити рандомними числами.Той елемент, що потрібно додати, також взяти рандомно.
    #endregion
    {
        static void Main(string[] args)
        {
            int[] originalArray = new int[10];
            // Fill array with random numbers
            FillArray(originalArray);
            // Print originalArray
            #region Variant via CopyTo method to temp array
            Console.WriteLine("Variant 1");
            Print(originalArray);
            Console.Write("=> "); // separator
            Print(CopyToTempArray(originalArray));
            #endregion
            #region Variant via CopyTo method to temp array
            Console.WriteLine("\nVariant 2");
            Print(originalArray);
            Console.Write("=> "); // separator
            Print(LoopForFilling(originalArray));
            #endregion
            #region Variant via Resize
            Console.WriteLine("\nVariant 3");
            Print(originalArray);
            Console.Write("=> "); // separator
            Print(ResizeArray(originalArray));
            # endregion
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
        private static int[] CopyToTempArray(int[] originalArray)
        {
            int[] tempArray = new int[originalArray.Length + 1];
            tempArray[0] = GenerateRandomNumber(-100, 101);
            originalArray.CopyTo(tempArray, 1);
            originalArray = tempArray;
            return originalArray;
        }
        private static int[] LoopForFilling(int[] originalArray)
        {
            int[] tempArray = new int[originalArray.Length + 1];
            tempArray[0] = GenerateRandomNumber(-100, 101);
            for (int i = 1; i < tempArray.Length; i++)
            {
                tempArray[i] = originalArray[i - 1];
            }
            originalArray = tempArray;
            return originalArray;
        }
        private static int[] ResizeArray(int[] originalArray)
        {
            Array.Resize(ref originalArray, originalArray.Length+1);
            for (int i = originalArray.Length - 1; i > 0; i--)
            {
                originalArray[i] = originalArray[i - 1];
            }
            originalArray[0] = GenerateRandomNumber(-100, 101);
            return originalArray;
        }
    }
}
