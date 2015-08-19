using System;
using System.Text.RegularExpressions;
using System.IO;

namespace _11.PrefixTest
{
    class PrefixTest
    {
        static void Main(string[] args)
        {
            //Write a program that deletes from a text file all words that start with the prefix test.
            //Words contain only the symbols 0…9, a…z, A…Z, _.

            var reader = new StreamReader(@"..\..\..\text2.txt");
            var writer = new StreamWriter(@"..\..\..\outputSymbols.txt");

            using (reader)
            {
                using (writer)
                {
                    string line = reader.ReadLine().ToLower();
                    while (line != null)
                    {
                        line = Regex.Replace(line, @"\btest\w*\b", string.Empty);
                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
            }
            Console.WriteLine("File is ready!");
        }
    }
}
