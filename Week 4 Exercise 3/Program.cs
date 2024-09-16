using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Exercise_3
{
    internal class Program
    {
        static void Main()
        {
            // Initialize the 2x3 matrix
            int[,] matrix = new int[2, 3]
            {
            { 1, 2, 3 },
            { 4, 5, 6 }
            };

            while (true)
            {
                // Prompts user with all options
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Print the matrix");
                Console.WriteLine("2. Calculate the sum of all elements");
                Console.WriteLine("3. Transpose the matrix and print it");
                Console.WriteLine("4. Exit");

                // Takes users input
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4."); // if input is invalid it prints this message
                    continue;
                }

                switch (choice)
                {
                    case 1: // print matrix
                        PrintMatrix(matrix);
                        break;
                    case 2: // sum of the matrix
                        CalculateSum(matrix);
                        break;
                    case 3: // transpose matrix
                        TransposeMatrix(matrix);
                        break;
                    case 4: // exit the program
                        return; 
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }
            }
        }

        static void PrintMatrix(int[,] matrix) // method for printmatrix
        {
            Console.WriteLine("Matrix:"); // prints line 
            for (int i = 0; i < matrix.GetLength(0); i++) // goes through array items
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],4}"); // prints the matrix 
                }
                Console.WriteLine();
            }
        }

        static void CalculateSum(int[,] matrix) // method for sum
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++) // goes through the matrix
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }
            Console.WriteLine($"Sum of all elements: {sum}"); // prints the sum of the matrix
        }

        static void TransposeMatrix(int[,] matrix) // method for transposematrix
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] transposed = new int[cols, rows];

            // Transpose the matrix
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++) // goes through matrix to transpose
                {
                    transposed[j, i] = matrix[i, j];
                }
            }

            // Print the transposed matrix
            Console.WriteLine("Transposed Matrix:");
            for (int i = 0; i < transposed.GetLength(0); i++) // goes through matrix
            {
                for (int j = 0; j < transposed.GetLength(1); j++)
                {
                    Console.Write($"{transposed[i, j],4}"); // Prints the transposed matrix
                }
                Console.WriteLine();
            }
        }
    }
}
