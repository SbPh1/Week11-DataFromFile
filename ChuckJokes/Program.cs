using System;
using System.IO;

namespace ChuckJokes
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(RandomLineFromFile());
            }

        }
        private static string RandomLineFromFile()
        {
            string filepath = @"C:\Users\monkey\samples\ChuckJokes.txt";
            string[] dataFromFile = File.ReadAllLines(filepath);
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, dataFromFile.Length);
            return dataFromFile[randomIndex];
        }
    }
    
}
