using System.Text;
using System.Text.RegularExpressions;

/// <summary>
/// Useful methods for processing strings in the Ukrainian language
/// </summary>
namespace UkrainianStringUtilsLib

    #region Task
    //    творіть клас UkrainianStringUtils, який буде містити корисні методи для обробки рядків українською мовою.

    //Клас UkrainianStringUtils та методи створити статичними, тобто позначаючи модифікаторами static (с. 141-142)

    //1) Реалізуйте метод CountVowels, який приймає рядок і повертає кількість голосних літер у ньому.

    //2) CountConsonants: Метод для підрахунку кількості приголосних літер у рядку.

    //3) Реалізуйте метод ReverseString, який приймає рядок і повертає його обернену версію.

    //4) RemoveDuplicates: Метод для видалення дублікатів символів з рядка, залишаючи тільки перше входження кожного символу.

    //5) RemovePunctuation: Метод для видалення всіх знаків пунктуації з рядка.
    #endregion
{

    public static class UkrainianStringUtils
    {
        /// <summary>
        /// Checks if character is a vowel
        /// </summary>
        private static bool IsVowel(char ch)
        {
            ch = char.ToLower(ch);
            return "аеєиіїоуюя".Contains(ch);
        }

        /// <summary>
        /// Counts number of vowels in the input string
        /// </summary>
        public static int CountVowels( string input) 
        {
            int vowelCount = 0;
            foreach (char ch in input )
            {
                if ( IsVowel(ch) )
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }
        /// <summary>
        /// Checks if character is a consonant
        /// </summary>
        private static bool IsConsonant(char ch)
        {
            ch = char.ToLower(ch);
            return "бвгґджзйклмнпрстфхцчшщ".Contains(ch);
        }

        /// <summary>
        /// Counts number of consonants in the input string
        /// </summary>
        public static int CountConsonants(string input)
        {
            int consonantsCount = 0;

            foreach (char ch in input)
            {
                if (IsConsonant(ch))
                {
                    consonantsCount++;
                }
            }

            return consonantsCount;
        }

        /// <summary>
        /// Reverse for input string
        /// </summary>
        public static string ReverseString( string input )
        {
            return new string( input.Reverse().ToArray() );
        }

        /// <summary>
        /// Removes duplicate characters from input string
        /// </summary>
        public static string RemoveDuplicates(string input)
        {
            return new string(input.Distinct().ToArray());
        }

        /// <summary>
        /// Deletes punctuation marks ONLY
        /// </summary>
        public static string RemovePunctuation(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));
            // regex replaces punctuation marks only according to reqs but if needed it can be complicated
            return Regex.Replace(input, @"\p{P}", "");
        }
    }
}
