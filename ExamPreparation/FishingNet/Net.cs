using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        private List<Fish> fish;
        public Net(string material, int capacity)
        {
            Material=material;
            Capacity=capacity;
            fish = new List<Fish>();

        }
        
        public string Material { get; set; }
        public int Capacity { get; set; }
        public List<Fish> Fish => fish;

        public int Count { get { return fish.Count; } }
        public string AddFish(Fish fish)
        {
            if(fish.FishType==null || fish.FishType==" " || fish.Length<=0 || fish.Weight<=0) 
            {
                return "Invalid fish.";
            }
            if(Capacity<Fish.Count)
            {
                return "Fishing net is full.";
            }
            else
            {
                Fish.Add(fish);
                Capacity--;
                return $"Successfully added {fish.FishType} to the fishing net.";
            }
        }
        public bool ReleaseFish(double weight)
        {
            for (int i=0;i<fish.Count;i++)
            {
                if (fish[i].Weight==weight && fish!=null)
                {
                    fish.RemoveAt(i);
                    Capacity++;
                    return true;
                }
            }
            
                return false;

        }
        public Fish GetFish(string fishType) => fish.FirstOrDefault(p => p.FishType == fishType);
        public	Fish GetBiggestFish()
        {

            Fish BigestFish = Fish[0];
            foreach (var fish in Fish)
            {
                if(fish.Length>BigestFish.Length)
                {
                    BigestFish = fish;
                }
            }
            return BigestFish;

        }
        public string	Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Into the {Material}:");
            fish = fish.OrderByDescending(p => p.Length).ToList();
            sb.AppendLine(string.Join(Environment.NewLine, fish));

            return sb.ToString().TrimEnd();


        }





    }
}
