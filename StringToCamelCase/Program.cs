using System;
using System.IO;

namespace StringToCamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            bool isFirstLine = true;

            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("test.txt"))
                {
                    string line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.Trim().ToLower();

                        if (String.IsNullOrEmpty(line))
                        {
                            result += " ";
                            isFirstLine = true;
                        }

                        else
                        {
                            result += isFirstLine ? line : FirstLetterUpperCase(line);
                            isFirstLine = false;
                        }
                    }

                    Console.WriteLine(result);
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        static String FirstLetterUpperCase(string s)
        {
            return s.Substring(0, 1).ToUpper() + s.Substring(1);
        }
    }
}
