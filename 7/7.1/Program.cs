using System;
using System.Collections.Generic;
using System.Text;
using Vegetablemarket;

namespace Sorting
{
        public class VGeneric
    {
        public static void Main(string[] args)
        {
            List<Vegetable> Vegetables = new List<Vegetable>(10);
            Vegetables.Add(new Vegetable(1,100, "broccoli", Vegetabletype.Flower)); 
            Vegetables.Add(new Vegetable(2,80, "spinach", Vegetabletype.Leafy));
            Vegetables.Add(new Vegetable(3,30, "Carrot", Vegetabletype.Root));
            Vegetables.Add(new Vegetable(4,200, "avocado", Vegetabletype.Fruit));
            Vegetables.Add(new Vegetable(5,50, "peanut", Vegetabletype.Seed));
           
       
            Console.WriteLine("\nVegetables SORTED AS PER NAME: ");
            Vegselectionsort.Sort<Vegetable>(Vegetables, Vegetable.CompareName);
            Vegetables.Reverse();
            foreach(Vegetable v1 in Vegetables)
            {
                Console.WriteLine(v1.Name);
            }

            Console.WriteLine("\nVegetables SORTED AS PER COST: ");
            Vegselectionsort.Sort<Vegetable>(Vegetables, Vegetable.CompareCost);
            foreach(Vegetable v1 in Vegetables)
            {
                Console.WriteLine($"{v1.Name} : RS {v1.Cost}");
            }
            
            Console.WriteLine("\nVegetables SORTED AS PER TYPE: ");
            Vegselectionsort.Sort<Vegetable>(Vegetables, Vegetable.CompareVegType);
            foreach(Vegetable v1 in Vegetables)
            {
                Console.WriteLine($"{v1.Name}  : {v1.vegetableType}");
            }

            
        }
    }
}