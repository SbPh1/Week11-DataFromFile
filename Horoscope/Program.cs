using System;
using System.IO;

namespace Horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Horoscope:");
            string userHoroscope = Console.ReadLine();
            string output = GetLineFromfileData(userHoroscope);
            if (output.Length != 0)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Sorry.The horoscope does not exist.");
            }
        }
        private static string[] ReadDataFromFile()
        {
            string directoryPath = @"C:\Users\monkey\samples";
            string filename = "horoscope.txt";
            string fullpath = $@"{directoryPath}\{filename}";
            string[] dataFromFile = File.ReadAllLines(fullpath);
            return dataFromFile;
        }
        private static string GetLineFromfileData(string userInput)
        {
            string[] dataFromFile = ReadDataFromFile();
            string result = "";
            foreach (string line in dataFromFile)
            {
                if (line.Contains(userInput))
                {
                    result = line;
                    break;
                }
            }
            return result;
        }
    }
}
