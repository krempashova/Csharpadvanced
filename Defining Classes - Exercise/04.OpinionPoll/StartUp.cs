using System;
using DefiningClasses;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
               
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new();
                person.Name = personInfo[0];
                person.Age = int.Parse(personInfo[1]);

                people.Add(person);   


            }

          List<Person>peopleOrdereByAge=people
                .Where(p=>p.Age>30)
                .OrderBy(n=>n.Name)
                .ToList();
            foreach (var item in peopleOrdereByAge)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");

            }

        }
    }
}
