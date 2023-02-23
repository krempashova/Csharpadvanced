using System;
using System.Text;
using GenericBoxofString;

namespace GenericBoxofString
{
    public class Box<T>
    {

        private List<T> values;
        public Box()
        {
            values = new List<T>();   
        }
        public void Add(T value) 
        { 
        values.Add(value);  
        }
        public override string ToString()
        {
            StringBuilder sb = new();
            foreach (var value in values)
            {
                sb.AppendLine($"{typeof(T)}: {value}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
