using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.MealPlan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mealsEatCount = 0;
            int leftcaloriesPerDay = 0;
            int takenCaloriesFromMeal = 0;
            //Dictionary<string, int> exactmeal = new Dictionary<string, int>()
            // {
            //    {"salad",350 },
            //    {"soup",490 },
            //    {"pasta",680 },
            //    {"steak",790 }            
            //};

            Queue<string> meals = new Queue<string>(Console.ReadLine()
           .Split(" ", StringSplitOptions.RemoveEmptyEntries));

             Stack<int> caloriesPerDay = new Stack<int>(Console.ReadLine()
             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse));
            while (meals.Any() && caloriesPerDay.Any())
            {
               
                    if(meals.Peek()=="salad")
                    {
                    takenCaloriesFromMeal = 350;
                        
                    }
                    else if(meals.Peek() == "pasta")
                    {
                        takenCaloriesFromMeal = 680;
                    }
                    else if(meals.Peek()== "steak")
                    {
                        takenCaloriesFromMeal = 790;
                    }
                    else if(meals.Peek()=="soup")
                    {
                        takenCaloriesFromMeal = 490;
                    }
                
                if(caloriesPerDay.Peek()- takenCaloriesFromMeal>0)
                {
                    // WE EAT THE MEAL, AND WE HAVE MORE cALORIES FOR THE DAY

                    leftcaloriesPerDay = caloriesPerDay.Pop() - takenCaloriesFromMeal;
                    meals.Dequeue();
                    mealsEatCount++;
                    caloriesPerDay.Push(leftcaloriesPerDay);
                    continue;
                }
                else
                {
                    leftcaloriesPerDay = Math.Abs(caloriesPerDay.Pop() - takenCaloriesFromMeal);
                    if(!caloriesPerDay.Any() && leftcaloriesPerDay>0)
                    {
                        mealsEatCount++;
                        meals.Dequeue();
                    }
                         
                    if (caloriesPerDay.Any())
                    {
                         leftcaloriesPerDay=caloriesPerDay.Pop() - leftcaloriesPerDay;
                        if(leftcaloriesPerDay>0)
                        {
                            meals.Dequeue();
                            mealsEatCount++;
                            caloriesPerDay.Push(leftcaloriesPerDay);
                        }

                    }
                    
                    
              
                    
                    
                }
                

            }

            if(!meals.Any())
            {
                Console.WriteLine($"John had {mealsEatCount} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ",caloriesPerDay)} calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {mealsEatCount} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ",meals)}.");
            }

        }
	
    }
}
