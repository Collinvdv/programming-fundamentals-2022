using System;

namespace palindrome
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int number;
            Boolean isNumber = int.TryParse(input, out number);

            if (isNumber)
            {
                if (input == reversed(input)) {
                    Console.WriteLine("Palindrome");
                } else
                {
                    Console.WriteLine("Not a palindrome");
                }
            } else
            {
                Console.WriteLine("Not a number");
            }
        }

        static string reversed(string word)
        {
            string reversed = "";

            for (int index = word.Length - 1; index >= 0 ; index--)
            {
                reversed += word[index];
            }

            return reversed;
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