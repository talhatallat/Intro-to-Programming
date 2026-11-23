/* 
 * Programmer Name: Talha Tallat
 * Brief: This program calculates user’s monthly medical insurance premium based on their age, BMI and smoking status.
*/

using System; // imports a system namespace containing many built-in .NET framework classes and types.

namespace Program1 // declaring a namespace called Program1 to organise related class and main code
{ //start of the namespace body.
    public class MedicalInsurance// declaring a class called MedicalInsurance, orgnises related data and main method in a structure. 'internal' access modifier makes accessible only within the same assembly, set by default if no access modifier is specified and also, cannot set private or protected access modifier to a top-level class, as it belongs directly to a namespace.
    { //start of the class body.
        static void Main(string[] args) // Creating a Main method - starting point for console, recognised by the C# compiler and .NET runtime
                                        //   | Method must have a return type - selecting a return type 'void' which returns nothing
                                        //   | access modifier must be 'static' for main method because it allows access to this main method globally, so to run this application, the .NET runtime needs to find the entry point (Main) and execute it
                                        //   | parameters of this main method contain array of strings and args name of parameter, allows arguments from CMD line.
                                        //     | (for example: if I run the program from command line and locating the .exe file, I can pass some arguments, they will be stored in this args array). can run the program without passing any arguments, in that case, args array will be empty.
        { //start of the main body
            Console.WriteLine("Please enter your details below to calculate your BMI, and medical insurance premium monthly."); // using WriteLine() method from class 'Console' in 'system' namespace, Prints text to the console and moves cursor to next line. 
            Console.Write("             Age: ");// using Write() method from Console class, which prints out text to the console without moving the cursor to next line.
            int age = int.Parse(Console.ReadLine()); // Creating a varible name called 'age' and assigning data type int which only store interger values ranging from -2,147,483,648 to 2,147,483,647.
                                                     //   || size: 4 byte, (4 * 8 bits = 32-bit)
                                                     // | Parsing - using Parse() method of class int to convert a string into a 32-bit signed integer, takes parameters in a string from user. returns the converted integer value
                                                     // | ReadLine() method of class Console from system, reads the entire line of input from user until the user presses Enter.
                                                     //   || Readline() method returns the input as a string by default.
                                                     // | = operator assigns back to the variable 'age'.
            Console.Write("             Height in meters: "); // again prints text on the console.
            float height = float.Parse(Console.ReadLine()); // Parsing again but now using float data type, which is a single-precision floating-point number, store decimal values
                                                            //  || float size: 4 byte, (4 * 8 bits = 32-bit)
                                                            //  || Stores decimal and fractional values with ~6–9 significant digits.
                                                            //  || Range: approximately -(3.4028235 * 10^38) to +(3.4028235 * 10^38).
            Console.Write("             Weight in kg: "); // print text on the console.
            float weight = float.Parse(Console.ReadLine()); // Parsing again using float data type asking user to input weight in kg.
            Console.Write("             No of medical insurance claims: "); // print text on the console.
            int claims = int.Parse(Console.ReadLine()); // Parsing again now using int data type asking user to input number of medical insurance claims.
            Console.Write("             Smoking status ('Y' for Yes, 'N' for no): "); // print text on the console.
            string smokeState = Console.ReadLine(); // .ReadLine() method again, asks user to input string data, already input data in string by default, also the data type assigned to the varible is string.
                                                    // | user input data, asigned to varaible called smokeState.


            float BMI = weight / (height * height); // calculating BMI, 
                                                    // operator / divides and * multiples
                                                    // assigned to variable BMI to a type float, float is sufficient for BMI calculations, as doube data type not nessary, unless the additional precision is required for BMI calculations. but float is goodenough for this.

            Console.WriteLine("\n\n╔════════════════════════════════╗"); 
            Console.WriteLine(    "║     Calculated BMI: {0:F1}       ║", BMI); // composite formating: {0} argument index 0, representing BMI variable. F1 = formats the number to one decimal place.
            Console.WriteLine(    "╠════════════════════════════════╣");
            

            float defaultPremium = 125; // float type variable called premium assgned to value 125
            double totalPremium = 0; // double type variable called totalPremium assigned to 0 (later to perform calculations and store final premium value), 64-bit (8-byte), ranging from (4.940656458 × 10^-324) to (1.7976931348623157 × 10^308) with ~15–17 significant decimal digits
            double surcharges = 0; // double type variable called surcharge assgned to 0 for now, later to update if surcharge apply.
            double discounts = 0; // double type variable called doscounts assigned to 0 (later to update if discounts apply)
            float addCharges = 0; // float type variable called addCharges assgned to 0 for now, later to update values if additional charges apply

            if (BMI < 25) // if statement takes conditions if BMI less than 25, if true then execute if body. < operator -> less than
            { //start of the if statment body.
                surcharges = 0; // then update the surcharge variable and assigned the value to 0.
                Console.WriteLine("\nYou are Healthy and there is {0} surcharge.", surcharges);// and then prints out the text on the console along with its argument at index 0
            } //end of the if body.
            else if (BMI > 25 && BMI < 30) // otherwise else if statement checks two conditions if BMI greater than 25 AND BMI less than 30, if both true then execute the else if body. && operator behaves like a logical AND. and > operator -> greater than
            { //start of the else if statment body.
                surcharges = 20; // then update the surcharge variable and assigned the value to 20.
                Console.WriteLine("\nYou are overweight and risk surcharge of {0} euro is applied.", surcharges);// and then prints out the text on the console along with its argument at index 0
            } //end of the else if body.
            else if (BMI > 30) // otherwise else if statement checks one condition if BMI greater than 30, if true then execute the else if body
            { //start of the else if statment body.
                surcharges = 40;// then update the surcharge variable and assigned the value to 40.
                Console.WriteLine("\nObese! a double risk surcharge of {0} euro is applied.", surcharges);// and then prints out the text on the console along with its argument at index 0
            } //end of the else if body.

            if (age < 18 && age > 60 && claims > 5) // if-statement takes three conditions if age less than 18 AND age greater than 60 AND claims greater than 5, if all three conditions true then execute if body.
            { //start of the if statment body.
                addCharges = 50;// then update the addCharges variable and assigned the value to 50.
                Console.WriteLine("Additional surcharge of {0} euro is applied.", addCharges); // and then prints out the text on the console along with its argument at index 0, denoting the additional charges applied to the total premium.
            } //end of the if body.
            else if (age < 18 || age > 60 && claims < 5) // elseif-statement takes three conditions if age less than 18 OR age greater than 60 AND claims less than 5, if all three conditions true then execute if-statement body.
            { //start of the else if statment body.
                discounts = 0.1;//then (0.1 = 10%) assignmed to the discounts variable, later to be used in the final premium calculation.
                Console.WriteLine("Receives 10% discount on the total premium."); // and then prints out the text on the console.
            } //end of the else if body.
            else if (age >= 18 && age <= 60) // elseif-statement takes two conditions if age greater than equal to 18 AND age less than equal to 60, if both conditions true then execute if-statement body.
            { //start of the else if statment body.
                addCharges = 25 * claims; // then update the addCharges variable by assigning the multiplication of 25 and claims.
                Console.WriteLine("Additional surcharge of {0} euro is applied.", addCharges); // and then prints out the text on the console along with its argument at index 0
            } //end of the else if body.
            else // else statment, if conditions are not met, executes the instrcution in the else-statment body.
            { //start of the else statment body.
                Console.WriteLine("Invalid Choice!"); // display Invalid Choice! text in the console.
            } //end of the else body.

            //another if statement to handle smoking status, if user is a smoker then apply 1.5 surcharge to the total premium, otherwise if user is a non-smoker then no surcharge applies.
            if (smokeState == "Y" || smokeState == "y" || smokeState == "YES" || smokeState == "yes") // if statement takes four conditions if the user types 'Y' OR'y' OR 'YES' OR 'yes', if any true then execute if body. == operator checks for equality || operator behaves like a logical OR.
            { //start of the if statment body.
                surcharges += 1.5; // then update the surcharge variable by adding 1.5 to the existing value of surcharges variable.
                Console.WriteLine("Smoker! Additional surcharge of {0} euro is applied.", surcharges); // and then prints out the text on the console along with its argument at index 0
            } //end of the if body.
            else if (smokeState == "N" || smokeState == "n" || smokeState == "NO" || smokeState == "no") // else if statement takes four conditions if the user types 'N' OR'n' OR 'NO' OR 'no', if any true then execute else if body.
            { //start of the if statment body.
                double pre = (defaultPremium + surcharges + addCharges);// calculating premium by adding defaultPremium, surcharges and addCharges and assigning to pre variable. pre is a double type variable, capable of storing decimal values with higher precision than float and great for calculations involving large numbers or precise decimal values.
                double addDiscount = pre * discounts; //sum of premium now multipled by the 10% discount and assigned to addDiscount variable, gave double data type to it due to the calculation and to store decimal values with higher precision than float.
                                                      //total premium is charged with the smoker * 1.5
                totalPremium = (pre - addDiscount) * (1.5); // and calculating total premium after applying discount if any, by subtracting the discount from the premium, and multiplying by 1.5 for smoker surcharge, and assigning to totalPremium variable. - operator subtracts.
                Console.WriteLine("The total premium multiplied by euro 1.50.");
            } //end of the if body.
            else if (smokeState == "N" || smokeState == "n" || smokeState == "NO" || smokeState == "no") // else-if statement takes four conditions if the user types 'N' OR 'n' OR 'NO' OR 'no', if any true then execute if-else body
            { //start of the else if statment body.
                double pre = (defaultPremium + surcharges + addCharges);// calculating premium by adding defaultPremium, surcharges and addCharges variables and assigning to pre variable. pre is a double type variable, capable of storing decimal values with higher precision than float and great for calculations involving large numbers or precise decimal values.
                double addDiscount = pre * discounts; //sum of premium now multipled by the 10% discount and assigned to addDiscount variable, gave double data type to it due to the calculation and to store decimal values with higher precision than float.
                totalPremium = pre - addDiscount; // and calculating total premium after applying discount if any, by subtracting the discount from the premium, and assigning to totalPremium variable. - operator subtracts.
                Console.WriteLine("non smoker! No furthur surcharge applies."); // and then prints out the text on the console.
            } //end of the else if body.
            else // if and else if conditions are not met, executes the instrcution in the body.
            { //start of the else statment body.
                Console.WriteLine("Invalid Choice!"); // display Invalid Choice! text in the console.
            } //end of the else body.

            //outputs to the console the final premium calculation, using composite formatting to display the values of defaultPremium, surcharges, addCharges, discounts and totalPremium variables in the output string.
            Console.WriteLine("\n\nFixed Premium: {0}\nTotal Surcharges: euro {1}\nTotal additional charges: {2}\nDiscounts: {3}\n\nFinal monthly premium: euro {4}", defaultPremium, surcharges, addCharges, discounts, totalPremium);
        } //end of the main body
    } //end of the class body.
} //end of the namespace body.
