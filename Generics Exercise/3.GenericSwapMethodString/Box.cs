using System;
using System.Text;
using GenericSwapMethodString;

namespace GenericSwapMethodString
{
    public class Box<T>
    {
        private List<T> items;
        public Box()
        {
            items = new List<T>();
        }
        public void Add(T item)
        {
            items.Add(item);
        }
        public void Swap(int firstindex, int secondindex)
        {
           (items[secondindex], items[firstindex]) = (items[firstindex], items[secondindex]);
        }
        public override string ToString()
        {
            StringBuilder sb = new();
            foreach (var item in items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString().TrimEnd();
        }
    }




}

