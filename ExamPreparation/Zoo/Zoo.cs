using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Zoo
    {
        private List<Animal> animals;
        public Zoo(string name,int capacity)
        {
            Name = name;
            Capacity = capacity;
            animals=new List<Animal>();
        }
        int countanimals = 0;
        public string Name { get; set; }
        public int  Capacity { get; set; }
        public List<Animal> Animals => animals;
        public 	string AddAnimal(Animal animal)
        {
            if(animal.Species==null || animal.Species==" ")
            {
                return "Invalid animal species.";
            }
            if(animal.Diet!="herbivore" && animal.Diet!="carnivore")
            {
                return "Invalid animal diet.";
            }
            if(Capacity<Animals.Count)
            {
                return "The zoo is full.";
            }
            else
            {
                animals.Add(animal);
                Capacity--;
                return $"Successfully added {animal.Species} to the zoo.";

            }
        }
        public int RemoveAnimals(string species) => animals.RemoveAll(a => a.Species == species);
        public List<Animal> GetAnimalsByDiet(string diet) => animals.FindAll(a => a.Diet == diet).ToList();
        public Animal GetAnimalByWeight(double weight)=>animals.FirstOrDefault(a=>a.Weight==weight);
        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            
            foreach (var animal in animals)
            { 
                if(animal.Length>= minimumLength && animal.Length<=maximumLength)
                {
                    countanimals++;
                }
                
            }
           return $"There are {countanimals} animals with a length between {minimumLength} and {maximumLength} meters.";
           
        }
        
           
        

    }
}
