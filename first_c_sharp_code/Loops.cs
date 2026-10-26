using System.Runtime.InteropServices;
using System;

namespace week4_loops
{
    public class exercise1
    {
        public void EvenOddNo()
        {
            Console.WriteLine("Enter a number between 0 and 1000 to determine even or odd: ");
            int number = int.Parse(Console.ReadLine());
            if (number >= 0 && number <= 1000) // nested loop
            {
                if ((number & 1) == 0)// & is bitwise AND operator. checks if the number is even
                {
                    Console.WriteLine("The number {0} is even.", number);
                }
                else
                {
                    Console.WriteLine("The number {0} is odd.", number);
                }
            }
            else
            {

                Console.WriteLine("The number {0} is out of range. Please enter a number between 0 and 1000.", number);
            }
        }
    }

    public class exercise2
    {
        public void ComparePrices()
        {
            Console.WriteLine("\nEnter the price of the 1st rice package: ");
            float ricePrice1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the weight of the 1st rice package in grams: ");
            int riceWeight1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter the price of the 2nd rice package: ");
            float ricePrice2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the weight of the 2nd rice package in grams: ");
            int riceWeight2 = int.Parse(Console.ReadLine());

            float comparePrice = ricePrice1 / ricePrice2;
            float compareWeight = riceWeight1 - riceWeight2;
            if (comparePrice < 1)
            {
                Console.WriteLine("\nThe 1st rice package is cheaper than the 2nd.");
            }
            else if (comparePrice > 1)
            {
                Console.WriteLine("\nThe 2nd rice package is cheaper than the 1st.");
            }
            else
            {
                Console.WriteLine("\nBoth rice packages have the same price.");
            }

            if (compareWeight > 0)
            {
                Console.WriteLine("\nThe 1st rice package is heavier than the 2nd.");
            }
            else if (compareWeight < 0)
            {
                Console.WriteLine("\nThe 2nd rice package is heavier than the 1st.");
            }
            else
            {
                Console.WriteLine("\nBoth rice packages have the same weight.");
            }

            float bestPrice = ricePrice1 / riceWeight1;
            float bestPrice2 = ricePrice2 / riceWeight2;
            if (bestPrice < bestPrice2)
            {
                Console.WriteLine("\nThe 1st rice package has the best price per gram.");
            }
            else if (bestPrice > bestPrice2)
            {
                Console.WriteLine("\nThe 2nd rice package has the best price per gram.");
            }
            else
            {
                Console.WriteLine("\nBoth rice packages have the same price per gram.");
            }
        }
    }

    public class exercise3
    {
        public void Perimeter()
        {
            Console.WriteLine("\nEnter the values of the triangle sides to calculate the perimeter\na: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("b: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("c: ");
            float c = float.Parse(Console.ReadLine());
            float perimeter = a + b + c;
            if (perimeter <= 0)
            {
                Console.WriteLine("\nThe perimeter of the triangle is invalid. Please enter valid values for the sides.");
                return;
            }
            else
            {
                Console.WriteLine("\nThe perimeter of the triangle is: {0}", perimeter);
            }
        }
    }

    public class exercise4
    {
        public void GuessNumber()
        {
            int secretNumber = 15;
            double sec_num_per = ((double)secretNumber/20) * 100; // mapping the secret number to a percentage 10 -> 50% | 20 -> 100%

            Console.WriteLine("Guess a number between 0 and 20 to see if you got it right: ");
            int num = int.Parse(Console.ReadLine());
            double num_per = ((double)num/20) * 100; // mapping the number to a percentage 10 -> 50% | 20 -> 100%
            Console.WriteLine("\nuserN: {0}\nsecN: {1}\ndiff: {2}\n", num_per, sec_num_per, num_per - sec_num_per);

            if (num_per == sec_num_per)
            {
                Console.WriteLine("Well done, you guessed correctly!");
            }
            else if (num_per < 0 || num_per > 100)
            {
                Console.WriteLine("The number you guessed is out of range. Please enter a number between 1 and 20.");
            }
            else if (num_per - sec_num_per >100) // 0-20 < 0-20 = -20 -> +20     range: -20->+20 mapping the range to 0-100% | 10n -> (50% - 100%) = -50% | 20n -> (100% - 100%) = 0%
            {
                Console.WriteLine("Your guess is too low, please try again: ");
            }
            else if (num_per - sec_num_per < 0 && num_per - sec_num_per >= -10)// 10n -> (50% - 100%)  = 50% | 20n -> (100% - 100%) = 0%
            {
                Console.WriteLine("Your guess is low but close, please try again");
            }
            else if (num_per - sec_num_per < -10 && num_per - sec_num_per >= -20)// 10n -> (50% - 100%)  = 50% | 20n -> (100% - 100%) = 0%
            {
                Console.WriteLine("Your guess is low, please try again");
            }
            else if (num_per - sec_num_per < -20 && num_per - sec_num_per >= -100)// 10n -> (50% - 100%)  = 50% | 20n -> (100% - 100%) = 0%
            {
                Console.WriteLine("Your guess is too low, please try again");
            }
            // if > 100
            else if (num_per - sec_num_per > 0 && num_per - sec_num_per <= 10)// 10n -> (50% - 100%)  = 50% | 20n -> (100% - 100%) = 0%
            {
                Console.WriteLine("Your guess is high but close, please try again");
            }
            else if (num_per - sec_num_per > 10 && num_per - sec_num_per <= 20)// 10n -> (50% - 100%)  = 50% | 20n -> (100% - 100%) = 0%
            {
                Console.WriteLine("Your guess is high, please try again");
            }

            else if (num_per - sec_num_per > 20 && num_per - sec_num_per <= 100)// 10n -> (50% - 100%)  = 50% | 20n -> (100% - 100%) = 0%
            {
                Console.WriteLine("Your guess is too high, please try again");
            }
        }
    }

    public class excercise5
    {
        public void Month()
        {
            Console.WriteLine("\nEnter a number from 1 to 12 to get the corresponding month: ");
            int monthNum = int.Parse(Console.ReadLine());

            switch (monthNum)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Invalid month number. Please enter a number between 1 and 12.");
                    break;
            }
        }
    }

    public class excercise6
    {
        public void HeadTail()
        {
            Console.WriteLine("\nEnter 0 or 1 to guess Heads or Tails ?: ");
            int userGuess = int.Parse(Console.ReadLine());

            Random random = new Random(); // Random Class, creates a new object of the Random Class. stores in variable random.
            int actualResult = random.Next(0, 1); // .Next() method comes from a Random class
            Console.WriteLine("The actual result is: {0}", actualResult);
            if (userGuess == actualResult)
            {
                Console.WriteLine("Congratulations! You guessed correctly.");
            }
            else
            {
                Console.WriteLine("Sorry, you guessed incorrectly.");
            }
        }
    }
}