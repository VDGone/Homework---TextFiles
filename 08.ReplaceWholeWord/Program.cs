using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace _08.ReplaceWholeWord
{
    class ReplaceWholeWord
    {
        static void Main(string[] args)
        {
            //Modify the solution of the previous problem to replace only whole words (not strings).
            var textReader = new StreamReader(@"..\..\..\text2.txt");
            var textWriter = new StreamWriter(@"..\..\..\replaceWordOutput.txt");
            using (textReader)
            {
                string line = textReader.ReadLine(); 
                using (textWriter)
                {
                    while (line != null)
                    {
                        line = line.ToLower();
                        line = Regex.Replace(line, @"\bstart\b", "finish");
                        textWriter.WriteLine(line);
                        line = textReader.ReadLine();
                    }
                }
            }
            Console.WriteLine("Successesful replacing!");
        }
    }
}
