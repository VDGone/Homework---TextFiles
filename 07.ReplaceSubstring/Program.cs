using System;
using System.Text;
using System.IO;

namespace _07.ReplaceSubstring
{
    class ReplaceSubstring
    {
        static void Main(string[] args)
        {
            //Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
            //Ensure it will work with large files (e.g. 100 MB).

            var textReader = new StreamReader(@"..\..\..\text2.txt");
            var textWriter = new StreamWriter(@"..\..\..\replaceOutput.txt");
            using (textReader)
            {
                string line = textReader.ReadLine();
                using (textWriter)
                {
                    while (line != null)
                    {
                        string replaceLine = line.Replace("start", "finish");
                        textWriter.WriteLine(replaceLine);
                        line = textReader.ReadLine();
                    }
                }
            }
            Console.WriteLine("Successesful replacing!");
        }
    }
}
