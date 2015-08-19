using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _10.ExtractTextFromXML
{
    class ExtractTextFromXML
    {
        static void Main(string[] args)
        {
            //Write a program that extracts from given XML file all the text without the tags.

            var reader = new StreamReader(@"..\..\..\XML.txt");
            var writer = new StreamWriter(@"..\..\..\XMLTMP.txt");
            Regex regex = new Regex(@">(?<data>[\s\w\d#]+)<");

            using (reader)
            {
                using (writer)
                {
                    string line = reader.ReadLine();
                    Match data;
                    while (line != null)
                    {
                        data = regex.Match(line);
                        while (data.Success)
                        {
                            string extractedData = data.Groups["data"].Value;
                            extractedData = extractedData.Trim();
                            writer.WriteLine(extractedData);
                            data = data.NextMatch();
                        }
                        line = reader.ReadLine();
                    }
                }
            }
            Console.WriteLine("Text was extracted!");
        }
    }
}
