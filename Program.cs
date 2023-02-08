using System;
using System.IO;

namespace BackendTest
{

    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Usage: SearchCSV <file path> <column number> <search key>");
                return;
            }

            string filePath = args[0];
            int columnNumber = int.Parse(args[1]);
            string searchKey = args[2];

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] values = line.Split(',');

                if (values.Length > columnNumber && values[columnNumber] == searchKey)
                {
                    Console.WriteLine(line);
                    return;
                }
            }

            Console.WriteLine("Key not found");
        }
    }
}
