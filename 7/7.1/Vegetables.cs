using System;




namespace Vegetablemarket{
class Vegselectionsort
    {
        static public void Sort<T>(IList<T> vegselectionsort, Func<T, T, bool> compare)
        {
            for (int i = 0; i < vegselectionsort.Count - 1; i++)
            {
                int key = i;
                for (int j = i + 1; j < vegselectionsort.Count; j++)
                {              
                    if (compare(vegselectionsort[j], vegselectionsort[key]))
                    {
                        key = j;
                    }
                }                      
                T temp = vegselectionsort[i];
                vegselectionsort[i] = vegselectionsort[key];
                vegselectionsort[key] = temp;
            }
        }

    }
    
    public enum Vegetabletype{
        Flower=1,
        Leafy =2,
        Root=3,
        Fruit=4,
        Seed=5              
    } 


        class Vegetable
        {
            int VegetablePrior;
            public float Cost;
            public string Name;
            public Vegetabletype vegetableType;

            public Vegetable(int vegetablepriority, float cost, string name, Vegetabletype vtype)
            {
                this.VegetablePrior = vegetablepriority;
                this.Cost = cost;
                this.Name = name;
                this.vegetableType = vtype;
            }

           internal static bool CompareCost(Vegetable v1, Vegetable v2)
            {
                return v1.Cost < v2.Cost;
            }

           internal static bool  CompareName(Vegetable v1, Vegetable v2)
            {
                if(v1.Name.CompareTo(v2.Name)== 1)
                {           
                    return true;
                }
                else
                {
                    return false;
                }

            }

           internal static bool  CompareVegType(Vegetable v1, Vegetable v2)
            {
                return v1.vegetableType < v2.vegetableType;
            }
        }
}