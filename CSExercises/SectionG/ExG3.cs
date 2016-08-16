using System;

namespace CSExercises
{
    //The C# language gives facilities for changing cases all to upper or lower - 
    //however, not to title case.  Write a program that would convert a given sentence/phrase to title case.
    //Example
    //“institute of systems science”   =>   “Institute Of System Science”

    public class ExG3
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            string newphrase = ToTitleCase(phrase.ToLower());

            Console.WriteLine(newphrase);
        }

        public static string ToTitleCase(string phrase)
        {
            char[] punctuation = new Char[] { '.', ',', ';', ':', '!', '\'', '\"', '-', ' ' };
            string[] wordsList = phrase.Split(punctuation);
            string[] newTitleWordList = new string[wordsList.Length];
            for (int i = 0; i < wordsList.Length; i++)
            {
                string word = wordsList[i];
                char[] upperCharArray = new char[word.Length];
                for (int j = 0; j < word.Length; j++)
                {
                    if (j == 0)
                    {
                        upperCharArray[j] = Char.ToUpper(word[j]);
                    }
                    else
                    {
                        upperCharArray[j] = word[j];
                    }
                }
                newTitleWordList[i] = new string(upperCharArray);
            }
                return string.Join(" ",newTitleWordList);
        }
    }
}
