using System;
using System.IO;

namespace _05.MaximalAreaSum
{
    class MaximalAreaSum
    {
        static void Main(string[] args)
        {
            //Write a program that reads a text file containing a square matrix of numbers.
            //Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
            //The first line in the input file contains the size of matrix N.
            //Each of the next N lines contain N numbers separated by space.
            //The output should be a single number in a separate text file.

            var matrixReader = new StreamReader(@"..\..\..\matrixInput.txt");
            var matrixWriter = new StreamWriter(@"..\..\..\matrixOutput.txt");
            int maxSum = 0;

            using (matrixReader)
            {
                int size = int.Parse(matrixReader.ReadLine());
                int[,] matrix = new int[size, size];

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    string[] line = matrixReader.ReadLine().Split(' ');

                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = int.Parse(line[col]);
                    }
                }

                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                    {
                        int temp = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                        if (temp > maxSum)
                        {
                            maxSum = temp;
                        }
                    }
                }
            }
            using (matrixWriter)
            {
                matrixWriter.WriteLine("Max area sum = {0}.", maxSum);
            }
            Console.WriteLine("File is ready!");
        }
    }
}
