using System;
using FractionalOp;
namespace mainprogram
{
    class Mainprog
    {
        public static void Main(){
            Console.WriteLine("Please enter the numerator?");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the denominator?");
            int denom = Convert.ToInt32(Console.ReadLine());
             
            Fraction F = new Fraction(num,denom);
            F.Divison();
            Console.WriteLine($"Floating point division result = {F.FloatingDivision()}");
            F.MixedFraction();
        }
    }
    
}