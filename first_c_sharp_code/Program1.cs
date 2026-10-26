using System;


namespace Program1
{
    public class MedicalInsurance
    {
        public void MonthlyPremium()
        {
            Console.Write("Enter Age: "); 
            int age = int.Parse(Console.ReadLine()); // 1
            Console.Write("Enter Height in meters: ");
            float height = float.Parse(Console.ReadLine()); // 2
            Console.Write("Enter Weight in kg: ");
            float weight = float.Parse(Console.ReadLine()); // 3
            Console.Write("No of medical insurance claims: ");
            int claims = int.Parse(Console.ReadLine()); // 4
            Console.Write("Smoking status ('Y' for Yes, 'N' for no): ");
            string smokeState = Console.ReadLine(); // 5

            float BMI = weight / (height*height);
            Console.WriteLine("\n\nCalculated BMI: {0}", BMI);

            float premium = 125;
            double totalPremium = 0;
            float surcharges = 0;
            double discounts = 0;
            float addCharges = 0;

            if (BMI < 25)
            {
                surcharges = 0;
                Console.WriteLine("\nYou are Healthy and there is {0} surcharge.", surcharges);
            }
            else if (BMI>25 && BMI<30)
            {
                surcharges = 20;
                Console.WriteLine("\nYou are overweight and risk surcharge of {0} euro is applied.", surcharges);//20
            }
            else if (BMI>30)
            {
                surcharges = 40;
                Console.WriteLine("\nObese! a double risk surcharge of {0} euro is applied.", surcharges); //40
            }

            if(age<18 && age>60 && claims>5)
            {
                addCharges = 50;
                Console.WriteLine("Additional surcharge of {0} euro is applied.", addCharges);
            }
            else if (age < 18 || age > 60 && claims < 5)
            {
                discounts = 0.1;//10%
                Console.WriteLine("Receives 10% discount on the total premium.");
            }
            else if (age >= 18 && age <= 60)
            {
                addCharges = 25 * claims;
                Console.WriteLine("Additional surcharge of {0} euro is applied.", addCharges);
            }
            else
            {
                Console.WriteLine("invalid.");
            }

            if(smokeState == "Y" || smokeState == "y" || smokeState == "YES" || smokeState == "yes")
            {
                double pre = (premium + surcharges + addCharges);//premium
                double addDiscount = pre * discounts; //10% discount
                //total premium is charged with the smoker * 1.5
                totalPremium = (pre - addDiscount) *(1.5);
                Console.WriteLine("The total premium multiplied by euro 1.50.");
            }
            else if(smokeState == "N" || smokeState == "n" || smokeState == "NO" || smokeState == "no")
            {
                double pre = (premium + surcharges + addCharges);//premium
                double addDiscount = pre * discounts; //10% discount
                totalPremium = pre - addDiscount;
                Console.WriteLine("non smoker! No furthur surcharge applies.");
            }
            else
            {
                Console.WriteLine("Invalid Choice!");
            }


            //output
            

            Console.WriteLine("\n\nFixed Premium: {0}\nTotal Surcharges: euro {1}\nTotal additional charges: {2}\nDiscounts: {3}\n\nFinal monthly premium: euro {4}", premium, surcharges, addCharges, discounts, totalPremium);

        }
    }
}


