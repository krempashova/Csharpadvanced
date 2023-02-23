SortedDictionary<string,int> elements = new();
Queue<int> textile = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));


   Stack<int> medicaments = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
while (textile.Any() && medicaments.Any())
{
    int combination = textile.Peek() + medicaments.Peek();
    if(combination==30)
    {
        //patch
        if(!elements.ContainsKey("Patch"))
        {
            elements["Patch"] = 1;
        }
        else
        {
            elements["Patch"]++;
        }
        textile.Dequeue();
        medicaments.Pop();
    }
    else if(combination==40)
    {
        if (!elements.ContainsKey("Bandage"))
        {
            elements["Bandage"] = 1;
        }
        else
        {
            elements["Bandage"]++;
        }
        textile.Dequeue();
        medicaments.Pop();

    }
    else if(combination==100)
    {
        if (!elements.ContainsKey("MedKit"))
        {
            elements["MedKit"] = 1;
        }
        else
        {
            elements["MedKit"]++;
        }
        textile.Dequeue();
        medicaments.Pop();
    }
    else if(combination>100)
    {
        if (!elements.ContainsKey("MedKit"))
        {
            elements["MedKit"] = 1;
        }
        else
        {
            elements["MedKit"]++;
        }
        
        int leftsum = combination - 100;
        textile.Dequeue();
        medicaments.Pop();
        int sumtoAddinmedicaments = medicaments.Pop() + leftsum;
        medicaments.Push(sumtoAddinmedicaments);


    }
    else
    {
        textile.Dequeue();
         int addmorenums=medicaments.Pop()+10;
        medicaments.Push(addmorenums);

    }



}

if(!textile.Any() && !medicaments.Any())
{
    Console.WriteLine("Textiles and medicaments are both empty.");
}
else if(!textile.Any() && medicaments.Any())

{
    Console.WriteLine("Textiles are empty.");
}
else if(textile.Any() && !medicaments.Any())
{
    Console.WriteLine("Medicaments are empty.");
}
foreach (var item in elements.OrderByDescending(x=>x.Value))
{
    
    if(item.Value>0)
    { 
        
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }

 if(medicaments.Any())
{
    Console.WriteLine($"Medicaments left: {string.Join(", ",medicaments)}");
}
 if(textile.Any())
{
    Console.WriteLine($"Textiles left: {string.Join(", ", textile)}");
}
