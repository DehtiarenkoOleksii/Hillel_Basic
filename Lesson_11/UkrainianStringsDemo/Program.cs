using UkrainianStringUtilsLib;

namespace UkrainianStringsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If you want to use variable

            //Console.OutputEncoding = System.Text.Encoding.Unicode;

            //string testString = "Юхууу, Всім Привіт! Це демонстрація методів бібліотеки с#.";

            //Console.WriteLine($"Вхідний текст: {testString}");
            //Console.WriteLine($"Кількість голосних: {UkrainianStringUtils.CountVowels(testString)}");
            //Console.WriteLine($"Кількість приголосних: {UkrainianStringUtils.CountConsonants(testString)}");
            //Console.WriteLine($"Реверс тексту: {UkrainianStringUtils.ReverseString(testString)}");
            //Console.WriteLine($"Видалення дублів: {UkrainianStringUtils.RemoveDuplicates(testString)}");
            //Console.WriteLine($"Видалення знаків пунктуації: {UkrainianStringUtils.RemovePunctuation(testString)}");
            #endregion

            #region If you want to input sentence in console

            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.Write("Введіть речення: ");
            string input = Console.ReadLine();

            Console.WriteLine($"Вхідний текст: {input}");
            Console.WriteLine($"Кількість голосних: {UkrainianStringUtils.CountVowels(input)}");
            Console.WriteLine($"Кількість приголосних: {UkrainianStringUtils.CountConsonants(input)}");
            Console.WriteLine($"Реверс тексту: {UkrainianStringUtils.ReverseString(input)}");
            Console.WriteLine($"Видалення дублів: {UkrainianStringUtils.RemoveDuplicates(input)}");
            Console.WriteLine($"Видалення знаків пунктуації: {UkrainianStringUtils.RemovePunctuation(input)}");
            #endregion
        }
    }
}
