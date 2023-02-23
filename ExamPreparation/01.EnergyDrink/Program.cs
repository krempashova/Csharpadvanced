
int totalcafeine = 0;

List<int> caffeine = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
Stack<int> stack = new(caffeine);

List<int> energy = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
Queue<int> queue = new(energy);

       int currenMultiply = 0;
while (stack.Count != 0 && queue.Count != 0)
{
    currenMultiply = totalcafeine;
    int currentcaffeine = stack.Pop();
    int currentdrink = queue.Dequeue();
    currenMultiply += currentcaffeine * currentdrink;
    if (currenMultiply > 300)
    {
        queue.Enqueue(currentdrink);
        if(totalcafeine>30)
        {

        
            totalcafeine -= 30;
        }
        
             
    }
    else
    {

        totalcafeine = currenMultiply;
    }
}
if(queue.Count!=0)
{
    Console.WriteLine($"Drinks left: {string.Join(", ",queue)}");
}
else 
{
    Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
}
Console.WriteLine($"Stamat is going to sleep with {totalcafeine} mg caffeine.");

