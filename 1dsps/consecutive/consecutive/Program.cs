using System;
using System.Collections.Generic;

namespace consecutive
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> numbers = convertStringToArrayInt("99 100 101");
  
            if (isConsecutiveList(numbers))
            {
                Console.WriteLine("The given is string is consecutive");
            } else
            {
                Console.WriteLine("The given is string is not consecutive");
            }
        }

        static bool isConsecutiveList(List<int> numbers)
        {
            Boolean isConsecutive = true;

            for (var index = minValue(numbers); index <= maxValue(numbers); index++)
            {
                if (numbers.Contains(index) == false)
                {
                    isConsecutive = false;
                }
            }

            return isConsecutive;
        }


        static List<int> convertStringToArrayInt(string input)
        {
            List<int> list = new List<int>();
            int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);

            foreach(int number in numbers)
            {
                list.Add(number);
            }

            return list;
        }

        static int maxValue(List<int> numbers)
        {
            int maximValue = 0;

            foreach(int number in numbers)
            {
                if (number > maximValue )
                {
                    maximValue = number;
                }
            }

            return maximValue;
        }

        static int minValue(List<int> numbers)
        {
            int minimumValue = 999999;

            foreach (int number in numbers)
            {
                if (number < minimumValue)
                {
                    minimumValue = number;
                }
            }

            return minimumValue;
        }
    }
}


// Check whether an entered sequence of numbers is consecutive or not.

// TESTCASES

// input
// 0 1 5 4 3 2

// output
// 0 1 2 3 4 5
// true

// input
// 0 1 5 3 2
// output
// 0 1 2 3 5
// false