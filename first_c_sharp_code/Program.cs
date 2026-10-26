using System; // importing System namespace which includes classes which will be used.
using System.Collections.Generic; // importing System.Collections.Generic namespace which includes classes which will be used.
using System.Linq; // importing System.Linq namespace which includes classes which will be used.
using System.Text; // importing System.Text namespace which includes classes which will be used.

using helloWorld; // importing helloWorld namespace from the Class1.cs file which includes classes which will be used.
using week2_exercise1;
using ex1 = week1_exercise1;
using ex2 = week1_exercise2;
using ex3 = week2_exercise1;
using ex4 = week4_loops;

using p1 = Program1; // Program1 namespace imported
using p2 = Program2;
using p3 = Program3;

namespace first_c_sharp_code // created HelloWorld namespace containing MainClass
{
    class Program // created a new class called MainClass
    {
        static void Main(string[] args) // public -> access modifier | static -> static method | void -> return nothing | Main -> method name | string[] args -> parameter
        {
            //Excercise1();
            //Excercise2();
            //Excercise3();
            //Exercise4();
            //Program1();
            //Program2();
            Program3();
        }

        static void Program3()
        {
            p3.CoffeePlants plants = new p3.CoffeePlants();
            plants.Plants();
        }

        static void Program2()
        {
            p2.chassBoard display = new p2.chassBoard(); // new operator creates an object in memory.
            display.displayChessboard();
        }

        static void Program1()
        {
            p1.MedicalInsurance premium = new p1.MedicalInsurance();
            premium.MonthlyPremium();
        }

        
        static void Exercise4()
        {
            ex4.exercise1 evenOdd = new ex4.exercise1();
            evenOdd.EvenOddNo(); 

            ex4.exercise2 riceCom = new ex4.exercise2();
            riceCom.ComparePrices();

            ex4.exercise3 calPer = new ex4.exercise3();
            calPer.Perimeter();

            ex4.exercise4 guess = new ex4.exercise4();
            guess.GuessNumber();

            ex4.excercise5 month = new ex4.excercise5();
            month.Month();

            ex4.excercise6 guessHT = new ex4.excercise6();
            guessHT.HeadTail();
        }

        static void Excercise3()
        {
            ex3.exercise1 conditions = new ex3.exercise1();
            conditions.AskUserConditions();

            ex3.excercise2 askAge = new ex3.excercise2(); // creates object excercie2 from week2_exercise1 namespace
            askAge.AskUserAge();

            ex3.excercise3 askAgeVerfify = new ex3.excercise3(); // creates object excercie3 from week2_exercise1 namespace
            askAgeVerfify.AgeVerification();

            ex3.excercise4 askSalary = new ex3.excercise4(); // creates object excercie4 from week2_exercise1 namespace
            askSalary.AskUserSalary();

            ex3.exercise5 askUserInt = new ex3.exercise5(); // creates object excercie5 from week2_exercise1 namespace
            askUserInt.ConvertIntoString();

            ex3.exercise6 askUserInt2 = new ex3.exercise6(); // creates object excercie6 from week2_exercise1 namespace
            askUserInt2.AskUserInput();

            ex3.exercise7 simpCal = new ex3.exercise7(); // creates object excercie7 from week2_exercise1 namespace
            simpCal.Menu();
        }

        static void Excercise1()
        {
            helloWorld.Class1 hw = new helloWorld.Class1();// creating an object of Class1 class from helloWorld namespace, and hw variable is used to access the methods of Class1 class.
            hw.SayHello();

            ex1.AmericanFlag pAf = new ex1.AmericanFlag();
            pAf.PrintFlag();

            ex1.ChristmasTree ct = new ex1.ChristmasTree();
            ct.PrintChristmasTree();

            ex1.Figure f = new ex1.Figure();
            f.PrintFigure();

            ex1.SumCal sum = new ex1.SumCal();
            sum.CalculateSum(10, 4);

            ex1.UserValue var = new ex1.UserValue();
            var.InputValue();

            ex1.UserSumValue sumOFInputValue = new ex1.UserSumValue();
            sumOFInputValue.InputSumValue();

            ex1.UserDivValue divOFInputValue = new ex1.UserDivValue();
            divOFInputValue.InputDivValue();
        }

        static void Excercise2()
        {
            ex2.exercise1 ex2_1 = new ex2.exercise1();
            ex2_1.UserIntVal();

            ex2.exercise2 exp = new ex2.exercise2();
            exp.Expression(3.5, 4, 2, 2.5);//*,*,/,-

            ex2.exercise3 square = new ex2.exercise3();
            square.Square(2, 2);

            ex2.exercise4 expression2 = new ex2.exercise4();
            expression2.Expression2(.5, 4, 2, 50.5, 1);


            ex2.exercise5 average = new ex2.exercise5();
            average.Average(44, 51);

            ex2.exercise6 time = new ex2.exercise6();
            time.Time();

            ex2.exercise7 userDetails = new ex2.exercise7();
            userDetails.UserDetails();
        }
     }
}