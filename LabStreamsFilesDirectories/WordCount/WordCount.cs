namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> output = new Dictionary<string, int>();
            
            using (StreamReader reader = new StreamReader(wordsFilePath)) 
            {
                string[] words = reader.ReadLine().Split(" ");
                foreach (var word in words)
                {
                    output.Add(word.ToLower(), 0);
                }
            }
            using (StreamReader reader = new StreamReader(textFilePath))
            {
                while (true)
                {
                    var line = reader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                   string[] words = line.Split(new char[] {' ','.','?','-',';',','});


                    foreach (var word in words)
                    {
                        if (output.ContainsKey(word.ToLower()))
                        {
                            output[word.ToLower()]++;
                        }
                    }
                }
            }
            using (StreamWriter writer=new StreamWriter(outputFilePath))
            {
                foreach (var kvp in output.OrderByDescending(w => w.Value))
                {
                    writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }


        }
    }
}
