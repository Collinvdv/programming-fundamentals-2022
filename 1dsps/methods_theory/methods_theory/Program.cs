using System;
using System.Collections.Generic;

namespace methods_theory
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> goats = new List<string>() { "T-rex", "Connie" };
            goats = reverseList(goats);
            printList(goats);

            List<string> chickens = new List<string>() { "henry", "wing" };
            printList(chickens);

            int totalAmountOfItems = getAmountOfLists(goats, chickens);
            Console.WriteLine(totalAmountOfItems);

            List<int> numbers = new List<int>() { 10, 20, 30 };
            printList(numbers);

        }

        static void printList(List<string> list)
        {
            Console.WriteLine("list");
            Console.WriteLine("------------");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void printList(List<int> list)
        {
            Console.WriteLine("list");
            Console.WriteLine("------------");
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }

        static List<string> reverseList(List<string> list)
        {
            List<string> reversedList = new List<string>();

            for (int index = list.Count - 1; index >= 0; index--)
            {
                reversedList.Add(list[index]);
            }

            return reversedList;
        }

        static int getAmountOfLists(List<string> list1, List<string> list2) {
            return list1.Count + list2.Count;
        }
    }
}
