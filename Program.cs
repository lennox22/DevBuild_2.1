using System;

namespace FizzBuss
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont = "y"; //needed to set up loop to repeat
            double length;
            double width;
            double height;
            double area;
            double perimeter;
            double volume;

            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!\n");

            while (cont == "y")
            {



                Console.Write("Enter Length: "); //grab the length and width
                length = Double.Parse(Console.ReadLine());
                Console.Write("Enter Width: ");
                width = Double.Parse(Console.ReadLine());
                Console.Write("Enter Height: ");
                height = Double.Parse(Console.ReadLine());

                area = length * width; //calculations
                perimeter = length * 2 + width * 2;
                volume = length * width * height;

                Console.WriteLine("Area: " + area); // displays calculations
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Volume: " + volume);

                if (area > 250 && area < 650) //medium room first, then the others don't matter
                {
                    Console.Write("This is a medium-sized room.");
                }
                else if (area <= 250)
                {
                    Console.Write("This is a small-sized room.");

                }
                else
                {
                    Console.WriteLine("This is a large-sized room.");

                }

                Console.Write("\n\nContinue? (y/n): ");  //asking to continue to start the loop over. Anything entered other than y will break loop
                cont = Console.ReadLine();
                Console.WriteLine();

            }

            Console.WriteLine("Thank you for using the Room Detail Generator!");




        }
    }
}
