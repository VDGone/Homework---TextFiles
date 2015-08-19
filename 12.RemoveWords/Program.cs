using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _12.RemoveWords
{
    class RemoveWords
    {
        static void Main(string[] args)
        {
           // Write a program that removes from a text file all words listed in given another text file.
           //Handle all possible exceptions in your methods.

            try
            {
                var reader =new StreamReader(@"..\..\..\text2.txt");
                var writer = new StreamWriter(@"..\..\..\ForbbidenWordsOutput.txt");
                using (reader)
                {
                    using (writer)
                    {
                        string line = reader.ReadLine().ToLower();
                        string regex = @"\b(" + String.Join("|", File.ReadAllLines(@"..\..\..\words.txt")) + @")\b";
                        while (line != null)
                        {
                            line = Regex.Replace(line, regex, string.Empty);
                            writer.WriteLine(line);
                            line = reader.ReadLine();
                        }
                    }
                }
                Console.WriteLine("File is ready!");
            }
            catch (FieldAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
