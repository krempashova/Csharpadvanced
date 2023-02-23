using System.Runtime.CompilerServices;

   Queue<string> peaksName = new
   ( new List<string>(){"Vihren", "Kutelo", "Banski Suhodol", "Polezhan", "Kamenitza" });

Stack<int> foodPortion = new(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Queue<int> stamina = new(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
Dictionary<string, int> peaks = new()
{
    {"Vihren",80 },
    { "Kutelo",90},
    {"Banski Suhodol",100},
    {"Polezhan",60 },
    {"Kamenitza",70 },



};
List<string> clumbedPeaks = new();

while (foodPortion.Any() && stamina.Any() && peaksName.Any())
{
    int totalsumforday = 0;
    totalsumforday = foodPortion.Pop() + stamina.Dequeue();
    int difficalty = peaks[peaksName.Peek()];
    if (totalsumforday>=difficalty)
    {
        clumbedPeaks.Add(peaksName.Dequeue());
    }
   

}
if(clumbedPeaks.Count==5)
{
    Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
}
else
{
    Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
}

if(clumbedPeaks.Any())
{
    Console.WriteLine("Conquered peaks:");
    Console.WriteLine(String.Join(Environment.NewLine,clumbedPeaks));
}
