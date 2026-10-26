using System;
using System.Xml.Linq;

namespace Program3
{
    public class CoffeePlants
    {
        public void Plants()
        {
            //int i = 1;
            /*
            char[,] chess = new char[8, 8]
            {
                { 'r', 'n', 'b', 'q', 'k', 'b', 'n', 'r' }, {}
            };
            */
            string id; string waterLevel; string lC; string pestDetect; string temp;
            int wL; int no; int t;

            //Console.WriteLine("{0}", id);

            for (int i=1; i<7; i++)
            {
                Console.WriteLine("\nPlease enter details for the coffee plant {0} -> ", i);

                while (true)
                {
                    Console.Write("    Plant Id (E.g., C001): ");
                    id = Console.ReadLine();
                    if ((!string.IsNullOrWhiteSpace(id)) && (id.All(char.IsLetterOrDigit)) && (id.Length <= 5)) // won't accept user input with null, spaces, sepecial characters and anything above 5 characters
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Enter ID only has letters and numbers upto 5 characters: ");
                    }
                }
                
                while (true)
                {
                    Console.Write("    Water level % (0-100): ");
                    waterLevel = Console.ReadLine();
                    if (int.TryParse(waterLevel, out wL) && (wL >= 0) && (wL <= 100))
                    {
                        break; // Exit the validation loop
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Enter a number only between 0 and 100.");
                    }
                }

                while (true)
                {
                    Console.Write("    Leaf colour (green, yellow, brown): ");
                    lC = Console.ReadLine();
                    if ((!string.IsNullOrWhiteSpace(lC)) && (lC.All(char.IsLetterOrDigit)) && (lC.Length <= 6) && (lC == "green") || (lC == "brown") || (lC == "yellow")) // won't accept user input with null, spaces, sepecial characters, anything above 6 characters, and other then green, yellow, brown
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Colours only green, yellow, brown max 6 letters accpted only.");
                    }            
                }

                while (true)
                {
                    Console.Write("    Number of pests detected: ");
                    pestDetect = Console.ReadLine();
                    if (int.TryParse(pestDetect, out no) && (no >= 1) && (no <= 100))
                    {
                        break; // Exit the validation loop
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Enter a number only between 1 and 100.");
                    }
                }
                                
                while (true)
                {
                    Console.Write("    Temperature (in Celsius): ");
                    temp = Console.ReadLine();
                    if (int.TryParse(temp, out t) && (t >= -100) && (t <= 100))
                    {
                        break; // Exit the validation loop
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Temperature value in digits, only ranging from -100 and 100.");
                    }
                }

                
                
                //Console.WriteLine("{0}: ", id);
                
            }
            //Console.WriteLine("{0}: ", i);
        }
    }
}

