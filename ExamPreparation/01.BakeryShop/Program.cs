using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Xml.Serialization;

namespace _01.BakeryShop
{
    internal class Program
    {
        static void Main(string[] args)
        {

         Dictionary<string,double> bakeryproducts = new Dictionary<string,double>();
       Queue<double> water = new Queue<double>(Console.ReadLine()
       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
       .Select(double.Parse));

            Stack<double> flour = new Stack<double>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse));

            while (water.Any() && flour.Any())
            {
                double mixed = water.Peek() + flour.Peek();//16.8+25.2=42
                double precentigewater = water.Peek() * 100 / mixed;
                double precentigeFlour = 100 - precentigewater;
                if(precentigewater==50 && precentigeFlour==50)
                {
                    //	Croissant 
                    if(!bakeryproducts.ContainsKey("Croissant"))
                    {
                        bakeryproducts["Croissant"] = 1;
                    }
                    else
                    {
                        bakeryproducts["Croissant"]++;
                    }
                    
                    water.Dequeue();
                    flour.Pop();
                }
                else if(precentigewater==40 && precentigeFlour==60)
                {
                    //mufin
                    if (!bakeryproducts.ContainsKey("Muffin"))
                    {
                        bakeryproducts["Muffin"] = 1;
                    }
                    else
                    {
                        bakeryproducts["Muffin"]++;
                    }
                  
                    water.Dequeue();
                    flour.Pop();
                }
                else if(precentigewater==30 && precentigeFlour==70)
                {
                    //bageta
                    if (!bakeryproducts.ContainsKey("Baguette"))
                    {
                        bakeryproducts["Baguette"] = 1;
                    }
                    else
                    {
                        bakeryproducts["Baguette"]++;
                    }
                    
                    water.Dequeue();
                    flour.Pop();

                }
                else if(precentigewater==20 && precentigeFlour==80)

                {
                    if (!bakeryproducts.ContainsKey("Bagel"))
                    {
                        bakeryproducts["Bagel"] = 1;
                    }
                    else
                    {
                        bakeryproducts["Bagel"]++;
                    }
                   
                    water.Dequeue();
                    flour.Pop();

                    //bagel
                }

                
                else
                {
                    double neededflour = water.Peek();
                    mixed = neededflour + water.Peek();
                    precentigewater = water.Dequeue() * 100 / mixed;
                    precentigeFlour = 100 - precentigewater;
                    double leftFlour = flour.Pop() - neededflour;
                    flour.Push(leftFlour);
                    if(!bakeryproducts.ContainsKey("Croissant"))
                    {
                        bakeryproducts["Croissant"]=1;
                    }
                    else
                    {
                        bakeryproducts["Croissant"]++;
                    }
                   
                   

                }
                

            }
            foreach (var item in bakeryproducts.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
            if(!water.Any())
            {
                Console.WriteLine("Water left: None");
            }
            else
            {
                Console.WriteLine($"Water left: {string.Join(", ", water)}");
            }

            if(!flour.Any())
            {
                Console.WriteLine("Flour left: None"); 
            }
            else
            {
                Console.WriteLine($"Flour left: {string.Join(", ", flour)}");
            }
        }
    }
}
