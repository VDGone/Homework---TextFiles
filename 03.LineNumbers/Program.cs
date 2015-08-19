using System;
using System.IO;

namespace _03.LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            //Write a program that reads a text file and inserts line numbers in front of each of its lines.
            //The result should be written to another text file.

            var textReader = new StreamReader(@"..\..\..\text1.txt");
            var textWriter = new StreamWriter(@"..\..\..\LineNumbers.txt");

            using (textWriter)
            {
                int count = 1;
                string line = textReader.ReadLine();
                while (line != null)
                {
                    textWriter.WriteLine("{0}. {1}", count, line);
                    count++;
                    line = textReader.ReadLine();
                }
            }
            Console.WriteLine("File is written!");
        }
    }
}
