using System;
using System.IO;

namespace _04.CompareTextFiles
{
    class CompareTextFiles
    {
        static void Main(string[] args)
        {
            //Write a program that compares two text files line by line and prints the number of lines that are the same
            //and the number of lines that are different.
            //Assume the files have equal number of lines.

            var readerTextOne = new StreamReader(@"..\..\..\text1.txt");
            var readerTextTwo = new StreamReader(@"..\..\..\text2.txt");
            int countEquals = 0;
            int countNotEquals = 0;

            using (readerTextOne) 
            {
                using (readerTextTwo)
                {
                    string lineOne = readerTextOne.ReadLine();
                    string lineTwo = readerTextTwo.ReadLine();
                    while (lineOne != null)
                    {
                        while (lineTwo != null)
                        {
                            if (lineOne == lineTwo)
                            {
                                countEquals++;
                                
                            }
                            if (lineOne != lineTwo)
                            {
                                countNotEquals++;
                                
                            }
                            lineOne = readerTextOne.ReadLine();
                            lineTwo = readerTextTwo.ReadLine();
                        }
                    }
                }
                Console.WriteLine("Equals - {0} lines, Not Equals - {1} lines.", countEquals, countNotEquals);
            }
        }
    }
}
