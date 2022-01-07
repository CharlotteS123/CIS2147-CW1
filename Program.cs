using System;
using System.Collections.Generic;
using System.Linq;

namespace W2
{
    class Program
    {
        /// <summary>
        /// Reads an inputted number and prints whether it is even or odd
        /// </summary>
        /// <param name="args"></param>
        static void exercise1()
        {
            Console.WriteLine("Enter a number to check ODD or EVEN");
            int a1 = Convert.ToInt32(Console.ReadLine());
            if (a1 % 2 == 0) { Console.WriteLine(a1 + " is an EVEN number"); }
            else { Console.WriteLine(a1 + " is an ODD number"); }
        }
        /// <summary>
        /// Reads a inputted number and prints whether it is odd or even, and whther it is a prime number
        /// </summary>
        /// <param name="args"></param>
        static void exercise2()
        {
            bool prime = false;
            Console.WriteLine("Enter a number to check ODD or EVEN, and if PRIME or NOT PRIME");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine(a + " is an EVEN number");
                if (a != 2) { prime = false; } // 2 is only even prime number
                else { prime = true; }
            }
            else
            {
                Console.WriteLine(a + " is an ODD number");
                if (a == 1) { prime = false; } // 1 is not greater than one therefore not prime
                else
                {
                    // For loop to check whether inputted number has any positive dividers
                    /// as that would make it not prime. Runs until either all iterations have been 
                    /// done, or until a number is divisible
                    for (int i = 3; i < (a); i = i + 2)
                    {
                        if (a % i != 0) { prime = true; }
                        else
                        { prime = false; break; } // ends program if it is not a prime
                    }
                }
            }
            if (prime == true) { Console.WriteLine(a + " is a prime number"); }
            else { Console.WriteLine(a + " isn't a prime number"); }
        }
        /// <summary>
        /// User enters a number and a pattern is printed with that many lines
        /// </summary>
        /// <param name="args"></param>
        static void exercise3()
        {
            string backwards = "";
            Console.WriteLine("Enter the maximum odd number of lines of *");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0) { Console.Write(a + " is not an odd number"); } // checks the inputted number is odd
            else
            {
                for (int i = 0; i < ((a / 2)); i++)
                {
                    string current = new string(' ', i) + "*" + new string(' ', (a - 2 - i - i)) + "*" + new string(' ', i);
                    Console.WriteLine(current);
                    backwards = current + "\n" + backwards; // will repeat first half but backwards when called later
                }
                Console.WriteLine(new string(' ', (a / 2 - 1 / 2)) + "*" + new string(' ', (a / 2 - 1 / 2))); // middle line
                Console.WriteLine(backwards);
            }
        }
        /// <summary>
        /// Reads a line from the user then prints it as all upper case
        /// </summary>
        /// <param name="args"></param>
        static void exercise4()
        {
            Console.WriteLine("Enter a sentence:");
            string st1 = Console.ReadLine();
            string final = "";
            List<char> lower = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            List<char> upper = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            for (int i = 0; i < st1.Length; i++) // For loop for the number of letters in the inputted sentence
            {
                int a = 0;
                for (int j = 0; j < 26; j++)
                {
                    if (st1[i] == lower[j]) { final += upper[j]; break; }
                    a += 1; // adds one for every letter in st1 that doesn't match
                }
                if (a == 26) // if the 'letter' isn't in the alphabet i.e. number or special character
                {
                    final += st1[i];
                }
            }
            Console.WriteLine(final);
        }
        /// <summary>
        /// Reads a user inputted line and prints whether it is a palindrome
        /// </summary>
        /// <param name="args"></param>
        static void exercise5()
        {
            Console.WriteLine("Please enter a word");
            string a = Console.ReadLine();
            bool palindrome = false;
            string justletters = new string(a.Where(c => Char.IsLetter(c)).ToArray()); // removes anything that isn't a letter
            justletters = justletters.ToUpper(); // Converts string into all upper case
            for (int i = 0; i < justletters.Length; i++) // for loop for iterating through whole line
            {
                if (justletters[i] == justletters[(justletters.Length - 1 - i)]) { palindrome = true; } // if that letter is same as one in opposite position of the word
                else { palindrome = false; break; }
            }
            if (palindrome == true) { Console.WriteLine(a + " is a palindrome."); }
            else { Console.WriteLine(a + " is not a palindrome."); }
        }
        /// <summary>
        /// Guessing game of the random number. User enters a number and gets told how close they are.
        /// Game continues 5 times or until the user guesses the correct number.
        /// </summary>
        /// <param name="args"></param>
        static void exercise6()
        {
            Random r = new Random();
            int r_num = r.Next(100); // random number between 0 and 100
            Boolean correct = false;
            for (int i = 0; i < 5; i++) // five guesses
            {
                Console.WriteLine("Guess number " + (i + 1) + (". Please guess the random number:"));
                int a = Convert.ToInt32(Console.ReadLine());
                if (r_num == a) // if guessed number is correct
                {
                    Console.WriteLine("Well done! You guessed the correct number after " + (i + 1) + " attempts!");
                    correct = true;
                    break;
                }
                else if (r_num > a) // if guessed number is lower than random number
                {
                    int c = r_num - a;
                    if (c >= 50) { Console.WriteLine("Your guess is very low"); }
                    else if (c >= 20) { Console.WriteLine("Your guess is low"); }
                    else if (c >= 10) { Console.WriteLine("Your guess is moderately low"); }
                    else { Console.WriteLine("Your guess is somewhat low"); }
                }
                else // if guessed number is greater than random number
                {
                    int c = a - r_num;
                    if (c >= 50)
                    { Console.WriteLine("Your guess is very high"); }
                    else if (c >= 20) { Console.WriteLine("Your guess is high"); }
                    else if (c >= 10) { Console.WriteLine("Your guess is moderately high"); }
                    else { Console.WriteLine("Your guess is somewhat high"); }
                }
            }
            if (correct == false) { Console.WriteLine("Better luck next time! The correct answer was " + r_num); } // if random number is never guessed
        }
        static void Main(string[] args)
        {
            exercise1();
            exercise2();
            exercise3();
            exercise4();
            exercise5();
            exercise6();
        }
    }
}
