using System;
using System.IO;

namespace _02.ConcatenateTextFiles
{
    class ConcatenateTextFiles
    {
        static void Main(string[] args)
        {
            //Write a program that concatenates two text files into another text file.

            var readerTextOne = new StreamReader(@"..\..\..\text1.txt");
            var readerTextTwo = new StreamReader(@"..\..\..\text2.txt");

            var streamWriter = new StreamWriter(@"..\..\..\ConcatenateFiles.txt");
            using (streamWriter)
            {
                string textOne = readerTextOne.ReadToEnd();
                string textTwo = readerTextTwo.ReadToEnd();

                streamWriter.WriteLine("{0} \r\n{1}", textOne, textTwo);
            }
            Console.WriteLine("File is written!");
        }
    }
}
