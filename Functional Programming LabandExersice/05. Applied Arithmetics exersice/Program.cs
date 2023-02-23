using System;
using System.Globalization;
using System.Linq;


Func<string, List<int>, List<int>> calculate = (comand, numbers) =>
{
    List<int> result = new();
    foreach (var number in numbers)
    {
        switch (comand)
        {
            case "add":
                result.Add(number+1);
                break;
            case "multiply":
                result.Add(number*2);   
                break;
            case "subtract":
                result.Add(number - 1);
                break;
        }
    }
    return result;
};


  Action <List<int>>printcomand = numbers 
    => Console.WriteLine(string.Join(" ",numbers));

     List<int> numbers = Console.ReadLine()
      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
      .Select(int.Parse)
      .ToList();

    string comand = string.Empty;
    while ((comand = Console.ReadLine()) != "end")
    {
        if (comand == "print")
        {

        printcomand(numbers);
        }
        else
        {
        numbers=calculate(comand, numbers);
        }

    }
