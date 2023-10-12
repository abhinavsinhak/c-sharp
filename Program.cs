using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] A = new int[rows, cols];
            int[,] B = new int[rows, cols];

            // Input for Matrix A
            Console.WriteLine("Enter values for Matrix A:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"A[{i},{j}]: ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Input for Matrix B
            Console.WriteLine("Enter values for Matrix B:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"B[{i},{j}]: ");
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Matrix Addition
            int[,] resultAddition = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resultAddition[i, j] = A[i, j] + B[i, j];
                }
            }

            // Display the result of matrix addition
            Console.WriteLine("Matrix Addition Result:");
            PrintMatrix(resultAddition);

            // Matrix Multiplication
            int[,] resultMultiplication = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resultMultiplication[i, j] = 0;
                    for (int k = 0; k < cols; k++)
                    {
                        resultMultiplication[i, j] += A[i, k] * B[k, j];
                    }
                }
            }

            // Display the result of matrix multiplication
            Console.WriteLine("Matrix Multiplication Result:");
            PrintMatrix(resultMultiplication);
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
