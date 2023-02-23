using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 + 5 + 10 - 2 - 1


            List<string> input = Console.ReadLine().Split().Reverse().ToList();


            Stack<string> expresssion = new Stack<string>(input);

            while (expresssion.Count!=1)
            {
                int leftnum = int.Parse(expresssion.Pop());//2
                string operation = expresssion.Pop();//+
                int rigthnum = int.Parse(expresssion.Pop());//5

                if(operation=="+")
                {
                    expresssion.Push((leftnum + rigthnum).ToString());
                }
                else if(operation=="-")
                {
                    expresssion.Push((leftnum - rigthnum).ToString());
                }



            }

            Console.WriteLine(expresssion.Pop());


        }
    }
}
