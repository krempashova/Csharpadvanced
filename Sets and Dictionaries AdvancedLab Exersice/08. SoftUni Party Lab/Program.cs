using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _08._SoftUni_Party_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
           HashSet<string>vipcusmoter= new HashSet<string>();
            string comand;
            HashSet<string> regularcustomer = new HashSet<string>();

            while ((comand=Console.ReadLine())!="PARTY" && comand!="END")
            {
                char firstchar = comand[0];
                    
                    if (comand.Length==8 && char.IsDigit(firstchar))
                    {
                        vipcusmoter.Add(comand);
                    }
                    else if(comand.Length==8)
                    {
                        regularcustomer.Add(comand);
                    }

                }
            
            while ((comand=Console.ReadLine())!="END")
            {
                if(vipcusmoter.Contains(comand))
                {
                    vipcusmoter.Remove(comand);
                }
                else if (regularcustomer.Contains(comand))
                {
                    regularcustomer.Remove(comand);
                }
            }
           
                int totalcount = vipcusmoter.Count + regularcustomer.Count;
                Console.WriteLine(totalcount);
                foreach (var vip in vipcusmoter)
                {
                    Console.WriteLine(vip);
                }
                foreach (var regular in regularcustomer)
                {
                    Console.WriteLine(regular);
                }
            
        }
    }
}
