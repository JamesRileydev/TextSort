using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TextSort
{
    class Program
    {
        static void Main(string[] args)
        {
            OpenFileToProcess();
        }

        public static Dictionary<string, int> OpenFileToProcess()
        {
            var filePath = "";
            String line;

            var dictionary = new Dictionary<string, int>();

            StreamReader sr = new StreamReader(filePath);

            line = sr.ReadLine();

            while (line != null)
            {
                if (dictionary.ContainsKey(line))
                {
                    dictionary[line]++;
                }
                else
                {
                    dictionary.Add(line, 1);
                }

                line = sr.ReadLine();
            }

            sr.Close();

            var sortedList = dictionary.OrderByDescending(i => i.Value);

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine(sortedList.ElementAt(x));
            }

            return null;
        }
    }
}
