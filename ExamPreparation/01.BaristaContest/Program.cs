using System;
using System.Linq;
internal class Program
{
    private static void Main(string[] args)
    {
        Queue<int> coffeQuantities = new Queue<int>(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));


        Stack<int> milkQuantities = new Stack<int>(Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse));

        Dictionary<string, int> countByDrinks = new Dictionary<string, int>();

        Dictionary<string, int> coffeDrinks = new Dictionary<string, int>()
{
    {"Cortado"   ,50 },
    { "Espresso",75 },
    {"Capuccino",100 },
    {"Americano",150},
    { "Latte",200 }
};

        while (coffeQuantities.Any() && milkQuantities.Any())
        {
            int totalQuantity = 0;
            totalQuantity = coffeQuantities.Peek() + milkQuantities.Peek();
            if (coffeDrinks.Any(s => s.Value == totalQuantity))

            {
                foreach (var kvp in coffeDrinks)
                {
                    if (kvp.Value == totalQuantity && !countByDrinks.ContainsKey(kvp.Key))
                    {
                        countByDrinks.Add(kvp.Key, 1);
                        coffeQuantities.Dequeue();
                        milkQuantities.Pop();
                        continue;

                    }
                    else if (kvp.Value == totalQuantity && countByDrinks.ContainsKey(kvp.Key))
                    {

                        countByDrinks[kvp.Key]++;
                        coffeQuantities.Dequeue();
                        milkQuantities.Pop();
                        continue;
                    }
                }
            }

            else

            {
                coffeQuantities.Dequeue();
                int newmilkquanity = milkQuantities.Pop() - 5;
                milkQuantities.Push(newmilkquanity);

            }
        }


        if (!coffeQuantities.Any() && !milkQuantities.Any())
        {
            Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
        }
        else
        {
            Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
        }


        var coffeeLeft = coffeQuantities.Count == 0 ? "none" : string.Join(", ", coffeQuantities);
        Console.WriteLine($"Coffee left: {coffeeLeft}");

        var milkLeft = milkQuantities.Count == 0 ? "none" : string.Join(", ", milkQuantities);
        Console.WriteLine($"Milk left: {milkLeft}");


        foreach (var drink in countByDrinks.OrderBy(x => x.Value).ThenByDescending(x => x.Key))
        {
            Console.WriteLine($"{drink.Key}: {drink.Value}");
        }
    }
}




