using System;

namespace palindrome
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            if (isNumber(input))
            {
                if (isPalindrome(input))
                {
                    Console.WriteLine("Palindrome");
                }
                else
                {
                    Console.WriteLine("Not a palindrome");
                }
            } else
            {
                Console.WriteLine("Not a number");
            }
            
        }

        static string reverseWord(string word)
        {
            string reversed = "";

            for(var index = word.Length - 1; index >= 0; index--)
            {
                reversed += word[index];
            }

            return reversed;
        }

        static Boolean isPalindrome(string word)
        {
            string reversedWord = reverseWord(word);

            return reversedWord == word;
        }

        static Boolean isNumber(string word)
        {
            int number;

            return int.TryParse(word, out number);
        }
    }
}

//  Write a C# Sharp program to check whether a given integer is a palindrome integer or not. Return true if the number is palindrome otherwise return false.

// *Expected Output:*

// Original integer value: 123456

//Check the said number is a palindrome number or not:

// False

// Original integer value: 16461

// Check the said number is a palindrome number or not:

// True

// Original integer value: -121

// Check the said number is a palindrome number or not:

// False