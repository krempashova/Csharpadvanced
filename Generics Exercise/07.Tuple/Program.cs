using System;
using Tuple;

string[] nameinfo = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

string[] beerinfo = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

string[] numsinfo = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);




CustomTuple<string, string> nameAndAdress = new($"{nameinfo[0]} {nameinfo[1]}", nameinfo[2]);

CustomTuple<string, int> nameAndBeer = new(beerinfo[0],int.Parse(beerinfo[1]));

CustomTuple<int, double> numbers =new(int.Parse(numsinfo[0]), double.Parse(numsinfo[1]));

Console.WriteLine(nameAndAdress);
Console.WriteLine(nameAndBeer);
Console.WriteLine(numbers);