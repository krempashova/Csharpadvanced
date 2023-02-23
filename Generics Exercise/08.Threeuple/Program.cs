using System;
using Threeuple;


string[] personinfo = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
string[] beerinfo = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
string[] bankinfo = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

CustomThreeuple<string, string, string> nameAdresTown =
    new($"{personinfo[0]} {personinfo[1]}", personinfo[2], string.Join(" ",personinfo[3..]));

CustomThreeuple<string, int, bool> beerAndLitters =
    new(beerinfo[0], int.Parse(beerinfo[1]), beerinfo[2]=="drunk");

CustomThreeuple<string, double, string> bankBalance =
    new(bankinfo[0], double.Parse(bankinfo[1]), bankinfo[2]) ;


Console.WriteLine(nameAdresTown);
Console.WriteLine(beerAndLitters);
Console.WriteLine(bankBalance);
