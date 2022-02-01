using System;

namespace FractionalOp
{  
         class Fraction
         {
       
            int num,denom;
            public Fraction(int a,int b){
                 this.num = a;
                 this.denom = b;
             }
            public double FloatingDivision(){
                        return ((float)num/denom);
             }

             public void Divison(){
                Console.WriteLine($"Integer division result = {(int)num/denom} with a remainder {num%denom}");
             }
             public void Simplification(){
                 int gcd = 0;
                 for(int i=1;i<denom;i++){
                     if(num%i==0 && num%i == 0){
                         gcd = i;
                     }
                 }
                 Console.WriteLine($"Integer division result =  {num/gcd}/{denom/gcd}");
             }
             
             public void MixedFraction(){
                    int wholeNum = (int)num/denom;
                    Console.WriteLine($"The result as a mixed fraction is = {wholeNum} {num%denom}/{denom}");
             }
         }
    
}