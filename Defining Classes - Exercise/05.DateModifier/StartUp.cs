
using System;

namespace Date_Modifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();

            int  differenceInDays = DateModifier.GerDeferenceBetweenDates(start,end);

            Console.WriteLine(differenceInDays);



        }
    }
}