//using System;

using System.ComponentModel.Design;

namespace helloWorld
{
	public class Class1
	{
        public void SayHello()
        {
            Console.Write("Hello");//Writes out text to the command line
            Console.WriteLine(", " + "World" + "!!"); //Concatination & writes to command line and start a newline

        }
    }
}

namespace week1_exercise1
{
    public class AmericanFlag
    {
        public void PrintFlag()
        {
            Console.WriteLine("\n*******----------------------------------\r\n*******----------------------------------\r\n*******----------------------------------\r\n*******----------------------------------\r\n-----------------------------------------\r\n-----------------------------------------\r\n");
        }
    }

    public class ChristmasTree
    {
        public void PrintChristmasTree()
        {
            Console.WriteLine("\n     *    \r\n    ***   \r\n   *****  \r\n  ******* \r\n *********\r\n");
        }
    }

    public class Figure
    {
        public void PrintFigure()
        {
            Console.WriteLine("\n (^;^)\n   |\n./ | \\.\n   |\n _/ \\_\n");
        }
    }

    public class SumCal
    {
        public void CalculateSum(int num1, int num2) // public accesable by other classes. void does not return a value. method containing two integer parameters num1 and num2
        {
            int sum = num1 + num2;
            Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
        }
    }

    public class UserValue
    {
        public void InputValue()
        {
            Console.WriteLine("Please enter a value: ");
            int var = int.Parse(Console.ReadLine());// ReadLine() method returns a string, therfore converting string type to integer using int.Parse() or int.TryParse()
            Console.WriteLine("Thanks! You entered: {0}", var);
        }
    }

    public class UserSumValue
    {
        public void InputSumValue()
        {
            int num1, num2;
            Console.WriteLine("\nAddition:\nPlease input value 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Pleae input value 2: ");
            num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine("The sum of {0} and {1} is: {2}", num1, num2, sum);
        }
    }

    public class UserDivValue
    {
        public void InputDivValue()
        {
            double num1, num2;
            Console.WriteLine("\nDividing:\nPlease input value 1: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input value 2: ");
            num2 = double.Parse(Console.ReadLine());

            double div = num1/num2;
            Console.WriteLine("The quotient of {0} and {1} is: {2}", num1, num2, div);
        }
    }
}




namespace week1_exercise2
{
    public class exercise1
    {
        public void UserIntVal()
        {
            Console.WriteLine("Increment first value:\n Please input value 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input value 2: ");
            int num2 = int.Parse(Console.ReadLine());
            int result = (num1+1)+num2;
            Console.WriteLine("The result is:{0}", result);
        }
    }

    public class exercise2
    {
        public void Expression(double valueM1, double valueM2, double valueD, double valueS)
        {
            double result = (((valueM1 * valueM2)/valueD)-valueS);
            Console.WriteLine("The result of expression is:{0}", result);
        }
    }

    public class exercise3
    {
        public void Square(int a, int b)
        {
            int result = (a*b)*(a*b);
            Console.WriteLine("The result of expression is:{0}", result);
        }
    }

    public class exercise4
    {
        public void Expression2(double a, double b, double c, double d, double r)
        {
            double result = (4/(3*(r+34))) - (9*(a+(b*c))) + 3 + ((d*(2+a))/(a+(b*d))) ;
            Console.WriteLine("The result of expression is:{0}", result);
        }
    }

    public class exercise5
    {
        public void Average(int mark1, int mark2)
        {
            double result = (mark1 + mark2) / 2.0;
            Console.WriteLine("The average of {0} and {1} is: {2}", mark1, mark2, result);
        }
    }

    public class exercise6
    {
        public void Time()
        {
            Console.WriteLine("Please enter time in seconds: ");
            int seconds = int.Parse(Console.ReadLine());
            int minutes = seconds  / 60;
            int remainder = minutes % 60; // 60×16=960 // 1000−960 = 40 //modulus operator returns the remainder of a division operation
            int t_hrs = minutes / 60; // (int)converts the result to an integer, taking off the decimal part.
            int hrs = t_hrs % 24; // 24×0=0 // 16−0 = 16   remainder of hours after converting to days
            int days = t_hrs / 24;
            Console.WriteLine("Time is: {0} days {1} hrs {2} min.", days, hrs, remainder);
        }
    }

    public class exercise7
    {
        public void UserDetails()
        {
            Console.WriteLine("Please enter your details below\nName: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your gross pay: ");
            int grossPay = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your Tax Rate in percentage (e.g., 20 for 20%): ");
            int taxRate = int.Parse(Console.ReadLine());
            int netPay = grossPay - (grossPay * taxRate / 100);
            Console.WriteLine("\nThanks! You entered: \nName - {0} \nAge - {1} \nGross Pay - {2} \nTax Rate - {3} \nNet Pay - {4}", name, age, grossPay, taxRate, netPay);
        }
    }
}


namespace week2_exercise1
{
    public class exercise1
    {
        public void AskUserConditions()
        {
            int num1, num2;
            Console.WriteLine("Please enter your first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 < num2)
            {
                Console.WriteLine("First number is less than the second!");
            }

            else if (num2 < num1)
            {
                Console.WriteLine("Second number is less than the first!");
            }

            else
            {
                Console.WriteLine("First number is equal to the second!");
            }
        }
    }

    public class excercise2
    {
        public void AskUserAge()
        {
            Console.WriteLine("Please enter your age to verify voting eligibility: ");
            int age;
            age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote!");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote!");
            }
        }
    }

    public class excercise3
    {
        public void AgeVerification()
        {
            Console.WriteLine("Please enter your age to verify trip eligibility: ");
            int age;
            age = int.Parse(Console.ReadLine());
            if (age >= 18 && age <= 30)
            {
                Console.WriteLine("You are eligible to go to on a trip!");
            }
            else
            {
                Console.WriteLine("You are not eligible to go to on a trip!");
            }
        }
    }

    public class excercise4
    {
        public void AskUserSalary()
        {
            Console.WriteLine("\nPlease enter your salary in digits only: ");
            float salary;
            salary = float.Parse(Console.ReadLine());
            if (salary < 10000)
            {
                Console.WriteLine("Net Pay: {0} @ 0% Tax Rate", salary);
            }
            else if (salary < 50000)
            {
                float gross_salary = salary * 20 / 100; // 20% tax rate
                float net = salary - gross_salary;
                Console.WriteLine("Gross Pay: {1} @ 20% Tax Rate \nNet pay: {0}", net, salary);
            }
            else
            {
                float gross_salary = salary * 40 / 100; // 40% tax rate
                float net = salary - gross_salary;
                Console.WriteLine("Gross Pay: {1} @ 40% Tax Rate \nNet pay: {0}", net, salary);
            }
        }
    }

    public class exercise5
    {
        public void ConvertIntoString()
        {
            Console.WriteLine("Please enter a number between (1-4) to see word it stores: ");
            int num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                string strNum = num.ToString("Diamonds");

                Console.WriteLine("The number {0} has been converted into a word: {1}", num, strNum);
            }
            else if (num == 2)
            {
                string strNum = num.ToString("Hearts");
                Console.WriteLine("The number {0} has been converted into a word: {1}", num, strNum);
            }
            else if (num == 3)
            {
                string strNum = num.ToString("Clubs");
                Console.WriteLine("The number {0} has been converted into a word: {1}", num, strNum);
            }
            else if (num == 4)
            {
                string strNum = num.ToString("Spades");
                Console.WriteLine("The number {0} has been converted into a word: {1}", num, strNum);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
            }
        }
    }

    public class exercise6
    {
        public void AskUserInput()
        {
            Console.WriteLine("Please enter a number between (1-7) to see the day of the week it represents: ");
            int days = int.Parse(Console.ReadLine());
            
            switch (days)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid input. There are only 7 days in a week.");
                    break;
            }
        }
    }

    public class exercise7
    {
        public void Menu()
        {
            Console.WriteLine("\nWelcome to the SimpleCalculator!\nPress 1 to add two numbers\nPress 2 to subtract two numbers\nPress 3 to divide two numbers\nPress 4 to multiple two numbers\nYour Choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose to add two numbers.\n1st number: ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("2nd number: ");
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("The sum of {0} and {1} is {2}.", num1, num2, num1 + num2);
                    break;
                case 2:
                    Console.WriteLine("You chose to subtract two numbers.\n1st number: ");
                    int num3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("2nd number: ");
                    int num4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("The difference of {0} and {1} is {2}.", num3, num4, num3 - num4);
                    break;
                case 3:
                    Console.WriteLine("You chose to divide two numbers.\n1st number: ");
                    float num5 = float.Parse(Console.ReadLine());
                    Console.WriteLine("2nd number: ");
                    float num6 = float.Parse(Console.ReadLine());
                    Console.WriteLine("The quotient of {0} and {1} is {2}.", num5, num6, num5 / num6);
                    break;
                case 4:
                    Console.WriteLine("You chose to multiply two numbers.\n1st number: ");
                    int num7 = int.Parse(Console.ReadLine());
                    Console.WriteLine("2nd number: ");
                    int num8 = int.Parse(Console.ReadLine());
                    Console.WriteLine("The product of {0} and {1} is {2}.", num7, num8, num7 * num8);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a number between 1 and 4.");
                    break;
            }
        }
    }
}