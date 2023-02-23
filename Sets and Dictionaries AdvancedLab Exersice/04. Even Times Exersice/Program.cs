using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times_Exersice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int count = 1;
            //    int eveNum = 0;
            //    int n = int.Parse(Console.ReadLine());
            //    HashSet<int> numbers = new HashSet<int>();
            //    for (int i = 0; i < n; i++)
            //    {
            //        int currnum = int.Parse(Console.ReadLine());
            //        if (numbers.Contains(currnum))
            //        {
            //            count++;
            //            eveNum = currnum;
            //        }
            //        else
            //        {
            //            numbers.Add(currnum);
            //        }

            //    }

            //    if (count % 2 == 0 && count!=0)
            //    {
            //        Console.WriteLine(eveNum);
            //    }

            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> repeatNums = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                if(!repeatNums.ContainsKey(currNum))
                {
                    repeatNums.Add(currNum, 1);
                }
             else
                {
                    repeatNums[currNum]++;
                }
            }

            foreach (var item in repeatNums.Where(x => x.Value % 2 == 0))
            {
                Console.WriteLine(item.Key);
            }
        }
           
        }
    }

