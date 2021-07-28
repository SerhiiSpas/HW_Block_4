using System;
using System.Collections.Generic;
using System.Linq;

namespace HW_17
{
    class welcome
    {
        static void Main(string[] args)
        {
  
            Console.WriteLine("Program for tracking student progress in C#" + "\n");

            Console.WriteLine("Enter student name\r");
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name + "! Choose an option from the following list\r");
            
            Console.WriteLine("\ta - Add");
            /*Console.WriteLine("\ts - ");
            Console.WriteLine("\tm - ");
            Console.WriteLine("\td - ");*/
            Console.Write("Your option? ");

            string enter = Console.ReadLine();
            if (enter == "a")
            {
                Console.Write("Enter the number of grade to be added:\t");
                int elementsGrade = int.Parse(Console.ReadLine());
                int[] ballMath = new int[elementsGrade];

                Console.WriteLine("Enter grade in Math\r");

                for (int i = 0; i < ballMath.Length; i++)
                {
                    Console.WriteLine($"Enter the grade under the index number {i}:\r");
                    ballMath[i] = int.Parse(Console.ReadLine());
                }

            }
            
        }
    }

    /*class Add
    {
        static void Main1(string[] args)
        {

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine("Your result: 1" );
                    break;
                case "s":
                    Console.WriteLine("Your result: 2");
                    break;
                case "m":
                    Console.WriteLine("Your result: 3");
                    break;
                case "d":
                    Console.WriteLine("Your result: 4");
                    break;
            }
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }*/
}
