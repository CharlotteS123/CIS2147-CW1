using System;

namespace W1
{
    class Pi
    {
        /// <summary>
        /// Returns the value 3.142.
        /// </summary>
        /// <returns> a double value of 3.142 </returns>
        public static double PI() { return 3.142; }
    }
    class Program
    {
        /// <summary>
        /// Collects two values from user then prints these numbers joined together.
        /// </summary>
        static void exercise1()
        {
            string s1, s2;
            Console.WriteLine("Enter value 1:");
            s1 = Console.ReadLine();
            Console.WriteLine("Enter value 2:");
            s2 = Console.ReadLine();
            Console.WriteLine("The entered values are: " + s1 + " and " + s2);
            int i1, i2;
            i1 = Convert.ToInt32(s1);
            i2 = Convert.ToInt32(s2);
            Console.WriteLine("The sum is " + (i1 + i2));
            Console.WriteLine("The sum is " + i1 + i2); // initial code that the exercise wants us to change
        }
        /// <summary>
        /// Reads two user inputs giving their name then prints this out in a sentence.
        /// </summary>
        static void exercise2()
        {
            Console.WriteLine("Please enter your name:");
            string firstname = Console.ReadLine();
            Console.WriteLine("Please enter your surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Your name is " + firstname + " " + surname);
        }
        /// <summary>
        /// Asks for the number of people and for their names, printing them in a sentence as it goes along.
        /// </summary>
        static void exercise3()
        {
            int i1;
            string s1, s2;
            Console.WriteLine("Please enter the number of people:");
            i1 = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < i1; j++) //runs for the amount of people given
            {
                Console.WriteLine("Person " + (j + 1) + ", please enter your name:");
                s1 = Console.ReadLine();
                Console.WriteLine("Person " + (j + 1) + ", please enter your surname:");
                s2 = Console.ReadLine();
                Console.WriteLine("The name of person " + (j + 1) + " is " + s1 + " " + s2);
            }
        }
        /// <summary>
        /// Asks the user for the radius of their circle, then prints the perimeter and area of that circle.
        /// </summary>
        static void exercise4()
        {
            Console.WriteLine("What is the radius of your circle?");
            double radius = Convert.ToInt32(Console.ReadLine());
            double pi = 3.142;
            double perimeter = pi * (radius + radius); //perimeter of circle = pi * diameter of circle
            double area = pi * radius * radius; // area of circle = pi * radius^2
            Console.WriteLine("The perimeter of your circle is " + perimeter);
            Console.WriteLine("The area of your circle is " + area);
        }
        /// <summary>
        /// Asks the user for the radius of their circle, then prints the perimeter and area of that 
        /// circle using a value for pi read in from Pi.cs.
        /// </summary>
        public static void exercise5()
        {
            Console.WriteLine("What is the radius of your circle?");
            double radius = Convert.ToInt32(Console.ReadLine());
            double pi = Pi.PI();
            double perimeter = pi * (radius + radius);
            double area = pi * radius * radius;
            Console.WriteLine("The perimeter of your circle is " + perimeter);
            Console.WriteLine("The area of your circle is " + area);
        }
        static void Main(string[] args)
        {
            exercise1();
            exercise2();
            exercise3();
            exercise4();
            exercise5();
        }
    }
}
