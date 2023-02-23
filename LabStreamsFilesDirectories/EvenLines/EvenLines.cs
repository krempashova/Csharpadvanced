namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line = reader.ReadLine();
                int countlines = 0;
                while (line!=null)
                {
                    if(countlines%2==0)
                    {
                        string replacedsymbols = Replacedsymbols(line);
                        string reversed = Reversed(replacedsymbols);
                        sb.AppendLine(reversed);
                    }



                   line = reader.ReadLine();
                    countlines++;
                }

            }
            return sb.ToString().TrimEnd();
        }

        private static string Reversed(string replacedsymbols)
        {
            string[] reversed = replacedsymbols.Split(" ").Reverse().ToArray();
            return string.Join(" ", reversed);
           
        }

        private static string Replacedsymbols(string line)
        {
            StringBuilder sb = new StringBuilder(line);
            string[] symboltoreplace = { "-", ",", ".", "!", "?" };
            foreach (var symbol in symboltoreplace)
            {
               sb.Replace(symbol, "@");
            }
            return sb.ToString();
        }
    }
}
