namespace MergeFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {

            List<string> lines = new List<string>();
            using (StreamReader firstinput = new StreamReader(firstInputFilePath))
            {
                using (StreamReader secondinput = new StreamReader(secondInputFilePath))
                {
                    string firstrow = firstinput.ReadLine();
                    string secondrow = secondinput.ReadLine();

                    while (firstrow != null || secondrow != null)
                    {

                        lines.Add(firstrow);

                        if (secondrow != null)
                        {
                            lines.Add(secondrow);
                        }

                        firstrow = firstinput.ReadLine();
                        secondrow = secondinput.ReadLine();
                    }

                }


            }
            using (StreamWriter whriter = new StreamWriter(outputFilePath))
            {

                foreach (var item in lines)
                {
                    whriter.WriteLine(item);
                }

            }
        }
    }
}
