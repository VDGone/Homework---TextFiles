using System;
using System.IO;

namespace _09.DeleteOddLines
{
    class DeleteOddLines
    {
        static void Main(string[] args)
        {
            //Write a program that deletes from given text file all odd lines.
            //The result should be in the same file.

            var reader = new StreamReader(@"..\..\..\oddLinesText.txt");
            var writer = new StreamWriter(@"..\..\..\oddLinesTextTMP.txt");

            using (reader)
            {
                using (writer)
                {
                    int lineCount = 0;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        if (lineCount % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }
                        line = reader.ReadLine();
                        lineCount++;
                    }
                }
            }

            var readerTwo = new StreamReader(@"..\..\..\oddLinesTextTMP.txt");
            var writerTwo = new StreamWriter(@"..\..\..\oddLinesText.txt");

            using (readerTwo)
            {
                using (writerTwo)
                {
                    string line = readerTwo.ReadLine();
                    while (line != null)
                    {
                        writerTwo.WriteLine(line);
                        line = readerTwo.ReadLine();
                    }
                }
            }
            File.Delete(@"..\..\..\oddLinesTextTMP.txt");
            Console.WriteLine("File is ready!");
        }
    }
}
