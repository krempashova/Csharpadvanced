using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using VetClinic;

namespace VetClinic
{
    public class Clinic
    {
      private List<Pet> pet;    

        public Clinic(int capacity)
        {
            Capacity = capacity;
            Pet = new List<Pet>();
        }

        public int Capacity { get; set; }
        public List<Pet> Pet { get; set; }

        public void Add(Pet pet)
        {
            if(Pet.Count<Capacity)
            {
                Pet.Add(pet);
            }
        }
        public bool Remove(string name)
        {
            for (int i = 0; i < Pet.Count; i++)
            {
                if (Pet[i].Name==name)
                {
                    Pet.RemoveAt(i);

                    return true;

                }              
            }
            return false;
        }
        public Pet GetPet(string name, string owner)
           => Pet.FirstOrDefault(p => p.Name == name && p.Owner == owner);
        public Pet GetOldestPet()
        {
            Pet oldestpet = Pet[0];
            foreach (var pet in Pet)
            {
                if (pet.Age > oldestpet.Age)
                {
                    oldestpet = pet;
                }
            }
            return oldestpet;
        }
        public int Count { get { return Pet.Count; } }
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The clinic has the following patients:");

            foreach (var pet in Pet)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return sb.ToString().Trim();
        }


    }
}
