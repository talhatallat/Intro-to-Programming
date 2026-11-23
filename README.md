# Medical Insurance
Write a C# program to calculate user’s monthly medical insurance premium based on  
their age, BMI and smoking status. 
The program should prompt the user to enter the following: 
1. Age 
2. Height in meters 
3. Weight in kilograms, 
4. Number of insurance claims 
5. Smoking status (‘Y’ for yes, ‘N’ for no)

   
The monthly premium starts at the base fee of EUR 125. 

The program should calculate user’s BMI using the correct formula. Based on BMI, 

  ● If BMI is less than 25, the user is healthy and there is no surcharge 

● If BMI between 25 and 30, then the user is overweight and a risk surcharge of EUR 20 is applied 

● If BMI is greater than 30, then the user is obese and a double risk surcharge is applied. 

After calculating the BMI, the program should check for its age and number of claims. 

● For users under 18 or above 60 and has more than five claims, an additional surcharge of EUR 50 is applied otherwise the user 
receives a 10% discount on the total premium. 

● For users aged 18 to 60, EUR 25 surcharge per claim is applied. 

Finally, if the user is a smoker, the total premium is charged with the smoker multiplier of EUR 1.50. 

Output should display the following: 

● Calculated BMI 

● Detailed breakdown of the surcharges or discounts 

● Final monthly premium, formatted correctly in EUR currency. 


# Chessboard
Write a C# program that generates and displays 8*8 chessboard using a two dimensional char array and nested loops. 
The chessboard should be initialized with the correct starting positions of all chess pieces. 

● Pieces: Black pieces should be represented by lowercase letters and white pieces by uppercase letters (Refer the table below)

● Empty Squares: The four middle rows of the board should alternate between black and white squares. Use # to represent an empty black 
square and * to represent an empty white square.



# Coffee Plants
Write a C# program that tracks and analyses the health status of multiple 
coffee plants in a plantation using arrays, strings, loops, and methods.  
The program should prompt the user to enter the following details for at least 
6 coffee plants storing the data in appropriate arrays: 
1. Plant Id (E.g., C001) 
2. Water level (%): 0 -100 
3. Leaf Colour (‘Green’, ‘Yellow’, ‘Brown’) 
4. Number of pests detected 
5. Temperature (in Celsius)

   
The program must contain the following methods:

● Ensure user inputs are valid before accepting them. The program should ask again if 
the input is invalid. 

● Evaluate the health of each plant based on the following criteria: 

Good: If the leaf colour is ‘Green’, number of pests detected are 0, water level between 40%-80%, and temperature between 14-27 degrees Celsius.

Moderate: If the leaf colour is ‘Yellow’, or number of pests detected are between 1-5, or water level is below 40 or above 80, temperature between 8-14 or 27-32 degrees Celsius. 

Poor: If the leaf colour is ‘Brown’, or number of pests detected are more than 5, or temperature is below 8 degrees Celsius or above 32 degrees Celsius. 

● Display a report to show each plant’s data and health status. At the end of the report, display a summary count of how many plants fall into Good, Moderate and Poor categories.
