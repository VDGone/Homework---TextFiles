using System;
using System.IO;

namespace _01.OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            //Write a program that reads a text file and prints on the console its odd lines.

            var reader = new StreamReader(@"..\..\..\text1.txt");
            
            using (reader)
            {
                int lineCount = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (lineCount % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }
                    lineCount++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}
