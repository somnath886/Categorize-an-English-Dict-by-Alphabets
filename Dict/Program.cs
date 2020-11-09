using System;
using System.Collections.Generic;
using System.IO;

namespace Dict
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"../../../large.txt");

            char first = 'a';

            string path = $"../../../DictbyAlpha(do not delete this folder)/{first}.txt";

            List<string> wordList = new List<string>();

            foreach (string line in lines)
            {
                if (line[0] == first)
                {
                    wordList.Add(line);
                }

                else if (line[0] != first)
                {
                    File.WriteAllLines(path, wordList.ToArray());

                    first = line[0];

                    path = $"../../../DictbyAlpha(do not delete this folder)/{first}.txt";

                    wordList.Clear();

                    wordList.Add(line);
                }
            }

            File.WriteAllLines(path, wordList.ToArray());
        }
    }
}