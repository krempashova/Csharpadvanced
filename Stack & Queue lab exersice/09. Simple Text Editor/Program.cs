using System;
using System.Collections.Generic;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countoperation=int.Parse(Console.ReadLine());
            Stack<string>changesMade=new  Stack<string>();
            string text = string.Empty;

            for (int i = 0; i < countoperation; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int comand = int.Parse(input[0]);
                switch (comand)
                {

                    case 1:
                        changesMade.Push(text);
                        
                        text += input[1];
                        break;
                    case 2:
                        changesMade.Push(text);
                        int count = int.Parse(input[1]);
                        text=text.Remove(text.Length - count);  

                        

                        break;
                    case 3:
                        int index = int.Parse(input[1])-1;
                        Console.WriteLine(text[index]);
                        
                        break;
                    case 4:
                        text = changesMade.Pop();

                        break;


                       

                   
                }




            }

        }
    }
}
