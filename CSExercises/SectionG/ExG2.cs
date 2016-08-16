using System;

namespace CSExercises
{
    //Write a C# program to determine if a given string is a palindrome.
    //    a.Your program should take a string from the console and test if the word is a palindrome or not using the approach explained by your instructor(you are expected to follow the steps given by the instructor)
    //–	A palindrome is a word/phrase that reads the same forwards or backwards.
    //–	Examples: ABBA, 747, radar, madam

    //b.	Modify the above program to accommodate sentences which may have upper case letters, punctuation or space that may need to be ignored while doing the test.
    //–	Examples:
    //A Santa at NASA
    //Mr.Owl ate my metal worm

    public class ExG2
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            if (IsPalindrome(phrase.ToLower()))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }

        public static bool IsPalindrome(string phrase)
        {
            bool isPalindrome = false;
            char[] punctuation = new Char[]{'.', ',',';',':','!','\'','\"','-',' '};
            string[] wordsList = phrase.Split(punctuation);

            for (int i = 0; i < wordsList.Length; i++)
            {
                string word = wordsList[i];
                char[] charArray =  new Char[word.Length];
                int size = word.Length - 1;
                for (int j = word.Length - 1; j >= 0; j--)
                {
                    charArray[size - j] = word[j];
                }
                string temp = new String(charArray);
                if (word.CompareTo(temp) == 0)
                {
                    isPalindrome = true;
                    break;
                }
                else
                {
                    isPalindrome = false;
                }
            }
                return isPalindrome;
        }

        public static bool IsPalindrome2(string phrase)
        {
            bool isPalindrome = false;
            char[] punctuation = new Char[] { '.', ',', ';', ':', '!', '\'', '\"', '-', ' ' };
            string[] wordsList = phrase.Split(punctuation);

            for (int i = 0; i < wordsList.Length; i++)
            {
                string word = wordsList[i];
                if (word.Length == 1)
                {
                    isPalindrome = true;
                    break;
                }
                int k = word.Length - 1;
                for(int j = 0; j < word.Length / 2; j++){
                    if (word[j] == word[k])
                    {
                        isPalindrome = true;
                    }
                    else
                    {
                        isPalindrome = false;
                        break;
                    }
                    k--;
                }
                
            }
            return isPalindrome;
        }
    }
}
