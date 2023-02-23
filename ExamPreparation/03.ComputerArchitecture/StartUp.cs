namespace ComputerArchitecture
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer("Gaming Serioux", 4);
            CPU cpu = new CPU("AMD Ryzen 5", 6, 3.7);
            Console.WriteLine(cpu);


        }
    }
}
