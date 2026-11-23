/* 
 * Programmer Name: Talha Tallat
 * Brief: This program generates and displays 8*8 chessboard using a two dimensional char array and nested loops.
*/

using System; // imports a system namespace containing many built-in .NET classes and types.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2 // declaring a namespace called Program2 to organise related class and code
{ //start of the namespace body.
    internal class ChassBoard // declaring a class called ChassBoard, which acts as a blueprint for creating objects. internal access modifier makes accessible only within the same assembly.
    { //start of the class body.
        static void Main(string[] args) // please navigate to Program1.cs for detailed explanation for this Main method
        { //start of the main body.
            char[,] chess = new char[8, 8]// Allocates memory for a two-dimensional array object containing 8 rows and 8 columns (64 char elements).
                    // The variable chess stores a reference to 2D array object.
            { //start of the array initialising body.
                { 'r', 'n', 'b', 'q', 'k', 'b', 'n', 'r' }, // Row 1: Black major pieces.  1x8        8 elements
                { 'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p' }, // Row 2: Black pawns.         2x8        8 elements
                { '*', '#', '*', '#', '*', '#', '*', '#' }, // Row 3: Alternating b/w square pattern. 8 elements
                { '#', '*', '#', '*', '#', '*', '#', '*' }, // Row 4: Alternating b/w square pattern. 8 elements
                { '*', '#', '*', '#', '*', '#', '*', '#' }, // Row 5: Alternating b/w square pattern. 8 elements
                { '#', '*', '#', '*', '#', '*', '#', '*' }, // Row 6: Alternating b/w square pattern. 8 elements
                { 'P', 'P', 'P', 'P', 'P', 'P', 'P', 'P' }, // Row 7: White pawns.         7x8        8 elements
                { 'R', 'N', 'B', 'Q', 'K', 'B', 'N', 'R' }  // Row 8: White major pieces.  8x8        8 elements
            }; //end of the array initialisations body.

            //Console.WriteLine(chess[0]);
            for (int i = 0; i < chess.GetLength(0); i++) // GetLength() method returns the number of elements in a specified dimension of an array. dimension (0) -> rows. increments through each iteration in chess array until the current index is less than the total number of rows.
            { //start of the outer for loop body.
                for (int j = 0; j < chess.GetLength(1); j++) // nested inner for loop, process all 8 coloums within the current row before the outer loop moves to the next row. 1x8. -> 2x8 -> 3x8 ...,  dimension(1) -> coloums 
                { //start of the inner for loop body.
                    Console.Write(chess[i, j] + " "); // printes characters in rows, columns with concatenation space in between.
                } //end of the inner for loop body.
                Console.WriteLine(); // WriteLine() method from class Console in system, moves cursor to next line, outside of inner loop, but inside of outer loop.
                //excutes and move the cursor to next line after each row. // like for example:
            } //end of the outer for loop body.                            // 1x8
        } //end of the main body.                                          // NEWLINE
    } //end of the class body.                                             // 2x8
} //end of the namespace body.                                             // NEWLINE ...