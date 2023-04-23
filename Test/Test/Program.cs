using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string inpPath = args[0];
            string outPath = args[1];
            Dictionary<string, int> textDic = new Dictionary<string, int>();
            using (StreamReader reader = new StreamReader(inpPath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    line = Regex.Replace(line, "<[^>]+>", string.Empty);
                    string[] text = line.Split(new[] { ' ', '\t', ',', '.', ':', ';', '!', '?', '(', ')', '[', ']', '{', '}', '-' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in text)
                    {
                        if (!textDic.ContainsKey(word.ToLower()))
                        {
                            textDic[word.ToLower()] = 1;
                        }
                        else
                        {
                            textDic[word.ToLower()]++;
                        }
                    }
                }
            }

            var sortedDic = textDic.OrderByDescending(w => w.Value);

            using (StreamWriter writer = new StreamWriter(outPath))
            {
                foreach (var word in sortedDic)
                {
                    writer.WriteLine("{0}   {1}", word.Key, word.Value);
                }
            }
            Console.WriteLine($"Output path in: {outPath}");
        }
    }
}
