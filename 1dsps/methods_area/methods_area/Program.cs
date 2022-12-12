using System;

namespace methods_area
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // What area calculate? [CIRCLE OR RECTANGLE]
            // I: rectangle
            // O: give me height
            // I: 10
            // O: give me width
            // I: 5
            // O: The result is 50

            Console.WriteLine("What area calculate? [CIRCLE OR RECTANGLE]");
            string shape = Console.ReadLine().ToLower();

            switch (shape)
            {
                case "circle":
                    // input
                    int radius = Convert.ToInt16(Console.ReadLine());

                    // output
                    printResult(calculateAreaOfCircle(radius));

                    break;

                case "rectangle":
                    // input
                    int width = Convert.ToInt16(Console.ReadLine());
                    int height = Convert.ToInt16(Console.ReadLine());

                    // output
                    printResult(calculateAreaOfRectangle(height, width));
                    break;
            }

        }

        static double calculateAreaOfCircle(double radius)
        {
            return radius * radius * Math.PI;
        }

        static double calculateAreaOfRectangle(int width, int height)
        {
            return width * height;
        }

        static void printResult(double area)
        {
            Console.WriteLine("The result is " + area + "m2");
        }
    }
}
