using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Program3
{
    class Record
    {
        public string ID;
        public int WL;
        public string LC;
        public int PD;
        public int T;
    }

    public class CoffeePlants
    {
        private Record[] records = new Record[3];

        public void Plants()
        {
            string id; string waterLevel; string lC; string pestDetect; string temp;
            int wL; int noPD; int t;


            for (int i = 0; i < records.Length; i++)
            {
                records[i] = new Record();
                //Console.WriteLine($"\nRecord {i + 1}");

                Console.WriteLine("\n╔══════════════════════════════════════╗");
                Console.WriteLine( $"║          COFFEE PLANT {i+1}              ║");
                Console.WriteLine(  "╚══════════════════════════════════════╝");
                
                while (true)
                {
                    Console.Write("    Plant Id (E.g., C001): ");
                    id = Console.ReadLine();
                    if ((!string.IsNullOrWhiteSpace(id)) && (id.All(char.IsLetterOrDigit)) && (id.Length <= 5)) // won't accept user input with null, spaces, sepecial characters and anything above 5 characters
                    {
                        records[i].ID = id;
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
                        records[i].WL = wL;
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
                        records[i].LC = lC;
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
                    if (int.TryParse(pestDetect, out noPD) && (noPD >= 0) && (noPD <= 100))
                    {
                        records[i].PD = noPD;
                        break; // Exit the validation loop
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Enter a number only between 0 and 100.");
                    }
                }

                while (true)
                {
                    Console.Write("    Temperature (in Celsius): ");
                    temp = Console.ReadLine();
                    if (int.TryParse(temp, out t) && (t >= -100) && (t <= 100))
                    {
                        records[i].T = t;
                        break; // Exit the validation loop
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Temperature value in digits, only ranging from -100 and 100.");
                    }
                }
            }
        }

        public void PlantHealth()
        {
            string leafColour = records[0].LC;
            Console.WriteLine("{0}", leafColour);
        }

        public void DisplayPlants() 
        {
            Console.WriteLine("\n╔════════════════════════════════╗" + "\n║          ALL RECORDS           ║" + "\n╚════════════════════════════════╝");
            int countGood = 0; int countPoor = 0; int countModerate = 0; 

            for (int i =0; i<records.Length; i++)
            {
                Console.WriteLine($"---------- Plant {i+1} -----------");
                Console.WriteLine("Plant ID:       {0}" +
                                "\nWater Level:    {1}%" +
                                "\nLeaf Colour:    {2}" +
                                "\nPest Detected:  {3}" +
                                "\nTemperature:    {4}°C", records[i].ID, records[i].WL, records[i].LC, records[i].PD, records[i].T);

                if (records[i].LC == "green" && records[i].PD == 0 && records[i].WL >= 40 && records[i].WL <= 80 && records[i].T >= 14 && records[i].T <= 27)
                {
                    countGood++;
                    Console.WriteLine($"Plant {i+1} Health: Good");
                }
                else if (records[i].LC == "yellow" || records[i].PD >= 1 && records[i].PD <= 5 || records[i].WL > 80 || records[i].WL < 40 || records[i].T >= 8 && records[i].T < 14 || records[i].T > 27 && records[i].T <= 32)
                {
                    countModerate++;
                    Console.WriteLine($"Plant {i + 1} Health: Moderate");
                }
                else if (records[i].LC == "brown" || records[i].PD > 5 || records[i].T < 8 || records[i].T > 32)
                {
                    countPoor++;
                    Console.WriteLine($"Plant {i + 1} Health: Poor");
                }
            }

            Console.WriteLine("\n╔════════════════════════════════╗");
            Console.WriteLine(  "║         PLANT SUMMARY          ║");
            Console.WriteLine(  "╠════════════════════════════════╣");
            Console.WriteLine(  "║  Good Plants:       {0} ║", countGood);
            Console.WriteLine(  "║  Moderate Plants:   {0} ║", countModerate);
            Console.WriteLine(  "║  Poor Plants:       {0} ║", countPoor);
            Console.WriteLine(  "╚════════════════════════════════╝");
        }
    }
}