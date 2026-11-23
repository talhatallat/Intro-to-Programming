/* 
 * Programmer Name: Talha Tallat
 * Brief: This program tracks and analyses the health status of multiple coffee plants in a plantation using arrays, strings, loops, and methods.  
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3 //declaring a namespace called Program3, to organise classes, methods, etc
{ // start of the namespace body
    public class MonitorPlantsHealth // declaring a public class called MonitorPlantsHealth to contain main method, acts as a blueprint for creating MonitorPlantsHealth objects. public access modifier allows the class to be accessible from any other class or assembly. cannot set private or protected access modifier to a top-level class, as it belongs directly to a namespace
    { // start of the class body
        static void Main(string[] args) // please navigate to Program1.cs for detailed explanation for this Main method
        { // start of the main body
            Console.OutputEncoding = System.Text.Encoding.UTF8; // selecting UTF-8 object of Encoding class in text namespace from system namespace, a character encoding that supports emojis and more.
            
            CoffeePlants plants = new CoffeePlants(); // creating an new object called plants of CoffeePlants class, which allows access to the methods and properties defined in the CoffeePlants class.
            plants.Plants(); // calling the Plants() method of the CoffeePlants class using the plants object.
            //plants.PlantHealth();
            plants.DisplayPlants();// calling the DisplayPlants() method of the CoffeePlants class using the plants object.
        } // end of the main body
    } // end of the class body

    class Record //declaring a class called Record, acts as a blueprint for creating Record objects.
    { //beginning of the class body.
        // declaring five instance variables (fields) of the Record class, that store data related to each coffee plant's health status.
        public string ID; // declaring a public string field called ID, has data type string, used to store text and takes up variable memory size UTF-16 (16 bit) 2 byte code units according to the Microsoft's official C#/.NET documentation.
        // public access modifier allows the field to be accessed whenever it is accessible through the object.
        public int WL; // declaring a public string field called WL, has data type intager of 4byte, 8b*4B =(32-bit), to store the water level percentage of the coffee plant.
        public string LC; //declaring a public string field called LC, has data type string, to store leaf colour of the coffe plant.
        public int PD; //declaring a public string field called PD, has data type intager of 4byte, to store the number of pests detected on the coffee plant. 
        public int T; //declaring a public string field called T has data type intager of 32bit (4byte), to store the temperature value of the coffee plant.
    } //end of the class body.

    public class CoffeePlants //creating a class called CoffeePlants
    { //beganing of the class body
        //declaring a instance variable records to array, not assigning a array's size. later user will be asked to the set the size, objects will be created to call this
        private Record[] records; // private means records variable belong to CoffeePlants class only, meaning plants() and displayPlants() methods can access, within CoffeePlants class. other classes won't directly access records. good practice.

        public void Plants() // method Plants() belong to CoffeePlants class, void return type returns nothing. public access modifier allows the method to be accessible from any other class or assembly.
        { //beganing of the method body
            while (true)    //while condition true, loop executes the instructions in the body. body repsented by curly brackets {}.
            {   //beganing of the while loop body.
                Console.Write("Enter the number of coffee☕ plants🌿 to monitor: "); // .Write() method of class Console from system, displays the text in the console on a single line and the cursor remains on the same line.
                string noOfPlants = Console.ReadLine(); // .ReadLine() method of class Console from system, asks user to input string data, also the data type assigned to the varible is string and .ReadLine() method reads the user input and moves to the next line.
                // if statement condition met then excutes the instruction present in the body. .TryParse(,) method of class int, converts a string into 32bit (4 byte) integer and handles invalid input by user without program crash. and the out parameter provides the converted integer
                if (int.TryParse(noOfPlants, out int noP) && (noP >= 0) && (noP <= 10)) // conditions - won't accept user input with null, spaces, text, sepecial characters and allows numbers ranging from 0 and 10.
                {   //beganing of the if body.
                    records = new Record[noP]; // then the variable records stores a reference to this object. new operator creates an object in memory. The noP variable containing user value determines the size of the records array, type of objects the array will hold.
                    break; // and breaks operator breaks the loop when user input meets the condition of if statment which is 0-10 integer value.
                }   //end of the if body.
                else   // if conditions are not met, executes the instrcution in the else body.
                {   //beganing of the else body.
                    Console.WriteLine("Invalid input. Enter a number only between 0 and 10.");// .WriteLine() method of class Console from system, displays the text in the console and moves to a new line.
                }   //end of the else body.
            } //end of the while loop body.


            for (int i = 0; i < records.Length; i++)// for loop iterates through the array from index 0 to the last index, array variable records, contains the size (no of plants) set by the user.
                                                    // and executes the set of series of instructions inside the loop body for each element.
            {//beganing of the for loop body.
                // records - the array variable, - [i] identify the index of array
                records[i] = new Record();// new operator creates a new object in memory - Record() calls the default constructor of the Record class to initialise a new object, a constructor is a special method that has the same name as the class and has no return type.

                Console.WriteLine("\n╔══════════════════════════════════════╗");
                Console.WriteLine($"║          COFFEE PLANT {i + 1}              ║");
                Console.WriteLine("╚══════════════════════════════════════╝");

                while (true) // again while loop for plant ID and handles invalud input from user and asks again until valid input presents.
                { //beganing of the while loop body.
                    Console.Write("    Plant Id (E.g., C001): "); // displays the text in the console on a single line and the cursor remains on the same line.
                    string id = Console.ReadLine(); // ask user to input string data, also the data type assigned to the varible is string and .ReadLine() method reads the user input and moves to the next line.
                    if ((!string.IsNullOrWhiteSpace(id)) && (id.All(char.IsLetterOrDigit)) && (id.Length <= 5)) // won't accept user input with null & spacesthanks to the built-in method IsNullOrWhiteSpace() of class string, sepecial characters and anything above 5 characters
                    { //beganing of the if body.
                        records[i].ID = id; // 
                        break; // and then exit the validation loop
                    } //end of the else body.
                    else // if conditions are not met, executes the instrcution in the else body. loops again if user input is invalid.
                    { //beganing of the else body.
                        Console.WriteLine("Invalid input. Enter ID only has letters and numbers upto 5 characters: ");// printes text to the console and moves to a new line.
                    } //end of the else body.
                } //end of the while loop body.

                while (true) // while condition true, loop executes the instructions in the body. body repsented by curly brackets {}.
                { // body - starting parentheses of while loop
                    Console.Write("    Water level % (0-100): "); // .Write() method of class Console from system, prints out the string on the console
                    string waterLevel = Console.ReadLine();// .ReadLine() method of class Console from system, asks user to input data in string because the data type assigned to the varible is string and .Read() method reads the user input in string. 
                    if (int.TryParse(waterLevel, out int wL) && (wL >= 0) && (wL <= 100)) // if statement condition met then excutes the instruction present in the body. .TryParse(,) method of class int, converts a string into 32bit (4 byte) integer and handles invalid input by user without program crash. and the out parameter provides the converted intger into the variable wL. if the wL variable is greater than equal to 0 and less than equal to 100. excute if conditions met.
                    {//beginning of the loop body.
                        records[i].WL = wL; // 
                        break; // and then exit the validation loop
                    }// end of the loop body
                    else // if conditions are not met, executes the instrcution in the body. loops again if user input is invalid.
                    { //beganing of the else body.
                        Console.WriteLine("Invalid input. Enter a number only between 0 and 100."); // .WriteLine() method of class Console from system, prints out the text in string on the console and adds a line
                    } //end of the else body.
                } // body - closing parentheses of while loop

                while (true)
                { //beganing of the while loop body.
                    Console.Write("    Leaf colour (green, yellow, brown): ");
                    string lC = Console.ReadLine();
                    if ((!string.IsNullOrWhiteSpace(lC)) && (lC.All(char.IsLetterOrDigit)) && (lC.Length <= 6) && (lC == "green") || (lC == "brown") || (lC == "yellow")) // won't accept user input with null, spaces, sepecial characters, anything above 6 characters, and other then green, yellow, brown
                    { //start of the if body.
                        records[i].LC = lC;
                        break; // and then exit the validation loop
                    } //end of the else body.
                    else // if conditions are not met, executes the instrcution in the body. loops again if user input is invalid.
                    { //beganing of the else body.
                        Console.WriteLine("Invalid input. Colours only green, yellow, brown max 6 letters accpted only.");
                    } //end of the else body.
                }

                while (true)
                { //beganing of the while loop body.
                    Console.Write("    Number of pests detected: ");
                    string pestDetect = Console.ReadLine();
                    if (int.TryParse(pestDetect, out int noPD) && (noPD >= 0) && (noPD <= 100))
                    { //strt of the if body.
                        records[i].PD = noPD;
                        break; // and then exit the validation loop
                    } //end of the if body.
                    else // if conditions are not met, executes the instrcution in the body. loops again if user input is invalid.
                    { //beganing of the else body.
                        Console.WriteLine("Invalid input. Enter a number only between 0 and 100.");
                    } //end of the else body.
                }

                while (true)
                { //beganing of the while loop body.
                    Console.Write("    Temperature °C: ");
                    string temp = Console.ReadLine();
                    if (int.TryParse(temp, out int t) && (t >= -100) && (t <= 100))
                    { //start of the if body.
                        records[i].T = t;
                        break; // and then exit the validation loop
                    } //end of the if body.
                    else // if conditions are not met, executes the instrcution in the body. loops again if user input is invalid.
                    { //beganing of the else body.
                        Console.WriteLine("Invalid input. Temperature value in digits, only ranging from -100 and 100.");
                    } //end of the else body.
                } //end of the while loop body.
            }//end of the for loop body.
        } //end of the method body.

        

        public void DisplayPlants() // DisplayPlants() method, has void return tyoe, retrns nothing. public access modifier. 
        { //beganing of the method body
            Console.WriteLine("\n╔════════════════════════════════╗" + "\n║     🪴COFFEE PLANTS DATA🪴     ║" + "\n╚════════════════════════════════╝");
            int countGood = 0; int countPoor = 0; int countModerate = 0; // assigned 0 to x3 varaibles that has data types int

            for (int i = 0; i < records.Length; i++)
            { //beganing of the foor loop body
                Console.WriteLine($"---------- Plant {i + 1} -----------");
                Console.WriteLine("Plant ID:       {0}" +
                                "\nWater Level:    {1}%" +
                                "\nLeaf Colour:    {2}" +
                                "\nPest Detected:  {3}" +
                                "\nTemperature:    {4}°C", records[i].ID, records[i].WL, records[i].LC, records[i].PD, records[i].T);

                // processing 
                if (records[i].LC == "green" && records[i].PD == 0 && records[i].WL >= 40 && records[i].WL <= 80 && records[i].T >= 14 && records[i].T <= 27)
                { //beganing of the if body.
                    countGood++;
                    Console.WriteLine($"Plant {i + 1} Health: Good");
                } //end of the if body.
                else if (records[i].LC == "yellow" || records[i].PD >= 1 && records[i].PD <= 5 || records[i].WL > 80 || records[i].WL < 40 || records[i].T >= 8 && records[i].T < 14 || records[i].T > 27 && records[i].T <= 32) //else if statement takes  conditions, if any true then execute if-else body
                { //beganing of the else if body.
                    countModerate++;
                    Console.WriteLine($"Plant {i + 1} Health: Moderate");
                } //end of the else if body.
                else if (records[i].LC == "brown" || records[i].PD > 5 || records[i].T < 8 || records[i].T > 32)//else if statement takes four conditions, if any true then execute if-else body
                { //beganing of the else if body.
                    countPoor++;
                    Console.WriteLine($"Plant {i + 1} Health: Poor");
                } //end of the else if body.
            } //end of the for loop body

            Console.ResetColor();
            Console.WriteLine("\n╔════════════════════════════════╗");
            Console.WriteLine("║    🍃PLANT HEALTH SUMMARY🍃    ║");
            Console.WriteLine("╠════════════════════════════════╣");

            Console.Write("║  Good Plants:       ");

            Console.ForegroundColor = ConsoleColor.Green; // green text color for good plants count, thanks to bulit-in ConsoleColor enumeration of class Console from system namespace, which provides a set of named constants representing the colors that can be used in the console.
            Console.Write("{0}", countGood);
            Console.ResetColor(); // reset text color to default

            Console.WriteLine("          ║");


            Console.WriteLine("║  Moderate Plants:   {0}          ║", countModerate);
            Console.WriteLine("║  Poor Plants:       {0}          ║", countPoor);
            Console.WriteLine("╚════════════════════════════════╝");
        } //end of the method body.
    } //end of the class body.
} // end of the namespace body.