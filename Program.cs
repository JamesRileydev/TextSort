using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            dictionary.ToList();

            foreach (var item in dictionary.OrderBy(i => i.Value))
            {
                item.ToString();

                Console.WriteLine(item);
            }

            return dictionary;
        }

       
    }
}
