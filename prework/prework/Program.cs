using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prework
{
    class Program
    {
        static void Main(string[] args)
        {
            //CHALLENGE1
            //set up an array that accepts 5 integers
            int[] fiveNumbersArray = new int[5];
            Console.WriteLine("Please enter 5 numbers between 1-10: ");

            //traverse through the array
            for (int i = 0; i < fiveNumbersArray.Length; i++)
            {
                //prompt user to enter a number, store it as a string, and display on screen
                Console.WriteLine($"Number {i + 1}: ");
                string userAnswer = Console.ReadLine();

                //convert the entered number from a string into an integer
                int integer = Convert.ToInt32(userAnswer);
                //do this for all 5 numbers
                fiveNumbersArray[i] = integer;
        }

            ////to compile array and display on screen
            for (int i = 0; i < fiveNumbersArray.Length; i++)
            {
                Console.Write($"{fiveNumbersArray[i]},");
            }
            Console.ReadLine();


            Console.WriteLine("Please select one number from the array: ");
            string chosen = Console.ReadLine();
            int chosenNumber = Convert.ToInt32(chosen);

            int maxResult = MaxArrayResult(fiveNumbersArray, chosenNumber);
            Console.WriteLine($"Your score is: { maxResult}");
            Console.ReadLine();

            ////CHALLENGE2
            Console.WriteLine("Enter a year to see if it's a Leap Year: ");
            string year = Console.ReadLine();
            int testYear = Convert.ToInt32(year);
            LeapYear(testYear);

            //CHALLENGE3
            int[] threeNumbersArray = new int[3];
            Console.WriteLine("Please enter 3 numbers between 1-10 to see if the array is considered a perfect sequence: ");

            //traverse through the array
            for (int i = 0; i < threeNumbersArray.Length; i++)
            {
                //prompt user to enter a number, store it as a string, and display on screen
                Console.WriteLine($"Number {i + 1}: ");
                string userValue = Console.ReadLine();

                //convert the entered number from a string into an integer
                int number = Convert.ToInt32(userValue);
                //do this for all 3 numbers
                threeNumbersArray[i] = number;
            }

            PerfectSequence(threeNumbersArray);

        }

        static int MaxArrayResult(int[] fiveNumbersArray, int chosenNumber)
        {
            //loop through array to find out how many times the chosen number occurs
            int occurrences = 0;
            for (int i = 0; i < fiveNumbersArray.Length; i++)
            {
                if (chosenNumber == fiveNumbersArray[i])
                {
                    occurrences++;
                }
            }

            int score = occurrences * chosenNumber;
            return score;

        }

        static void LeapYear(int testYear)
        {
            //use conditions to test for Leap Year
            if ((testYear % 4 == 0 && testYear % 100 != 0) || (testYear % 400 == 0))
            {
                Console.WriteLine($"{testYear} is a Gregorian Leap Year");
            }
            else
            {
                Console.WriteLine($"{testYear} is not a Gregorian Leap Year");
            }
            Console.ReadLine();
        }

        static void PerfectSequence(int[] threeNumbersArray)
        {
            int sum = 0;
            foreach (int value in threeNumbersArray)
            {
                sum += value;
            }
            int product = 1;
            foreach (int value in threeNumbersArray)
            {
                product *= value;
            }
            //perfect sequence if the sum equal to the product
            if (sum == product)
            {
                Console.WriteLine($"Yes, perfect sequence");
            }
            else
            {
                Console.WriteLine("No, not a perfect sequence");
            }
            Console.ReadLine();
        }
    }


}
