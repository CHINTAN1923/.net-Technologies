using System;
namespace  NumbersOpr
{
    class Operations {
        public static void arithmatic(){
            Console.WriteLine("\nExploring arithmetic operations\n");
            int a = 10;
            int b = 2;
            int c = a + b;
            int d = a - b;
            int e = a * b;
            int f = a / b;
            Console.WriteLine("Addition is :" + c);
            Console.WriteLine("Subtraction is : " +d);
            Console.WriteLine("Multiplication is : " +e);
            Console.WriteLine("Division is : " +f);

        }

        public static void paranths(){
            Console.WriteLine("\nExploring Order Of Operation\n");
            int a = 5;
            int b = 4;
            int c = 2;
            Console.WriteLine("a=5 b=4 c=2");

            int d = a + b * c;
            Console.WriteLine("[a + b * c]  : " + d);

            int e = (a + b) * c;
            Console.WriteLine("[(a + b) * c]  : " + e);

            int f = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine("[(a + b) - 6 * c + (12 * 4) / 3 + 12] : " + f);

            int g = (a + b) / c;
            Console.WriteLine("[(a + b) / c] : " + g);

        }

        public static void prNli(){

        Console.WriteLine("\nExploring Integer precision and limits \n");
        int a = 7;
        int b = 4;
        int c = 3;
        int d = (a + b) / c;
        int e = (a + b) % c;
        Console.WriteLine("a=7 b=4 c=3");
        Console.WriteLine($"[(a + b) / c]  Quotient is : {d}");
        Console.WriteLine($"[(a + b) % c]  Remainder is : {e}");

        int max = int.MaxValue;
        int min = int.MinValue;
        Console.WriteLine($"Range of integer datatype is {min} to {max}");

        int what = max + 3;
        Console.WriteLine($"Overflow Example : {what}");

        }

        public static void doubleType(){
            Console.WriteLine("\nOperations with double data type\n");
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine("a=5 b=4 c=2");
            Console.WriteLine("[(a + b) / c] : " + d);


            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"Range of double data type is {min} to {max}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

        }

        public static void DeciTy(){
                Console.WriteLine("\nOperations with decimal data types\n");
                decimal min = decimal.MinValue;
                decimal max = decimal.MaxValue;
                Console.WriteLine($"Range of decimal data type is {min} to {max}");

                double a = 1.0;
                double b = 3.0;
                Console.WriteLine("a=1.0 b=3.0");
                Console.WriteLine("[a / b] Double : " + a / b);

                decimal c = 1.0M;
                decimal d = 3.0M;
                Console.WriteLine("c=1.0M d=3.0M");
                Console.WriteLine("[c / d] Decimal : " + c / d);
        

        }

        public static void Area(){
            Console.WriteLine("\nArea of a circle\n");
            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine("Area of a circle is  : " + area);

        }
    
}
}
