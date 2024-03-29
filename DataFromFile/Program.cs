﻿using System;
using System.IO;

namespace DataFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite color:");
            string userColor = Console.ReadLine();
            string output = GetLineFromfileData(userColor);
            if (output.Length != 0)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Sorry. Color not found.");
            }
        }
        private static string[] ReadDataFromFile()
        {
            string directoryPath = @"C:\Users\monkey\samples";
            string filename = "personality.txt";
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
