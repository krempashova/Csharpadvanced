using System;


    List<int> numbers = Console.ReadLine().
    Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();//1 2 3 4 5 6

     int divider = int.Parse(Console.ReadLine());//2


Func<List<int>, Predicate<int>, List<int>> excludenumbers = (numbers, match) =>
{
      List<int> result = new();
    foreach (var number in numbers)
    {
        if(match(number))
        {
            result.Add(number);
        }
    }


    return result;
};
numbers = excludenumbers(numbers,n=>n % divider!=0);

Func<List<int>, List<int>> reversednumbers = numbers =>
{
      numbers.Reverse();

    return numbers;
};

numbers = reversednumbers(numbers);

Console.WriteLine(string.Join(" ",numbers));
