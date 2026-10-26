using System;
using System.Runtime.InteropServices;

namespace Program2
{
    public class chassBoard
    {
        public void displayChessboard() 
        {
            char[,] chess = new char[8,8]// Allocates memory for a two-dimensional array object containing 8 rows and 8 columns (64 char elements). The variable chess stores a reference to this object.
            {
                { 'r', 'n', 'b', 'q', 'k', 'b', 'n', 'r' }, // element 1
                { 'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p' }, // 2
                { '*', '#', '*', '#', '*', '#', '*', '#' }, // 3
                { '#', '*', '#', '*', '#', '*', '#', '*' }, // 4
                { '*', '#', '*', '#', '*', '#', '*', '#' }, // 5
                { '#', '*', '#', '*', '#', '*', '#', '*' }, // 6
                { 'P', 'P', 'P', 'P', 'P', 'P', 'P', 'P' }, // 7
                { 'R', 'N', 'B', 'Q', 'K', 'B', 'N', 'R' }  // 8
            };
            
            //Console.WriteLine(chess[0]);
            for (int i=0; i<chess.GetLength(0); i++) // .GetLenght(0) method gets the number of rows or columns separately. parameter (0) -> rows. (1) -> coloums. loops through each one present in chess array.
            {
                for (int j = 0; j<chess.GetLength(1); j++) // nested inner for loop, loops through numbr of columns present in chess aray.
                {
                    Console.Write(chess[i, j] + " "); // printes characters in rows, columns with concatenation space in between.
                }
                // move to next line after each row. outside of inner loop.
                Console.WriteLine(); 
            }
        }
    }
}

