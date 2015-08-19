using System;
using System.IO;
using System.Linq;

namespace _06.SaveSortedNames
{
    class SaveSortedNames
    {
        static void Main(string[] args)
        {
            //Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

            var textReader = new StreamReader(@"..\..\..\text2.txt");
            var textWriter = new StreamWriter(@"..\..\..\sortOutput.txt");

            using (textReader)
            {
                string[] words = textReader.ReadToEnd().Split();
                Array.Sort(words);

                using (textWriter)
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(words[i]) && words[i].Length > 1)
                        {
                            textWriter.WriteLine(words[i]);
                        }  
                    }
                }
            }
            Console.WriteLine("File is ready!");
        }
    }
}
