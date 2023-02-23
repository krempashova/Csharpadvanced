using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeStore
{
    public class ShoeStore
    {
        public ShoeStore(string name, int storagecapacity)
        {
            Name = name;
            StorageCapacity = storagecapacity;
            shoes = new List<Shoe>();
        }

        private List<Shoe> shoes;

        public string Name { get; set; }
        public int StorageCapacity { get; set; }
        public List<Shoe> Shoes => shoes;


        public int Count { get { return shoes.Count; } }    
         public string AddShoe(Shoe shoe)
        {
            if(Shoes.Count == StorageCapacity)
            {
                return "No more space in the storage room.";
            }
            else
            {
                Shoes.Add(shoe);
                return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
            }
        }
        public int RemoveShoes(string material) => shoes.RemoveAll(s => s.Material==material);
        public List<Shoe> GetShoesByType(string type) 
            => shoes.Where(s => s.Type.ToLower() == type.ToLower())
            .ToList();

        public Shoe GetShoeBySize(double size) 
            => shoes.FirstOrDefault(s => s.Size == size);
        public string StockList(double size, string type)
        {
            StringBuilder sb = new();
            IEnumerable<Shoe> stockList = shoes
                .Where(s => s.Size == size && s.Type == type);
            if(!stockList.Any())
            {
                return "No matches found!";
            }
            else
            {


                sb.AppendLine($"Stock list for size {size} - {type} shoes:");
                foreach (Shoe shoe in stockList)
                {
                    sb.AppendLine(shoe.ToString());
                }
                
            }
            return sb.ToString().Trim();
        }
        

    }
}
