using System;
namespace  LoopsinCsharp
{
    class Loops {

        public static void IFstm(){

                Console.WriteLine("\nMaking decision using if statment\n");
                int a = 5;
                int b = 6;
                if (a + b > 10)
                Console.WriteLine("Answer is grater than 10");

                int c = 5;
                int d = 3;
                if (c + d > 10)
                Console.WriteLine("answer is greater than 10");

        }

        public static void IfElsestm(){

            Console.WriteLine("\nMaking Decisoin using If else\n");
            int a = 5;
            int b = 3;
            int c = 4;
            if (a + b > 10)
                Console.WriteLine("Answer is grater than 10");
            else
                Console.WriteLine("Answer is not grater than 10");


            if (a + b > 10)
            {
                Console.WriteLine("Answer is grater than 10");
            }
            else
            {
                Console.WriteLine("Answer is not grater than 10");
            }



            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("Answer is grater than 10");
                Console.WriteLine("And the first number is equal to second");
            }
            else
            {
                Console.WriteLine("Answer is not grater than 10");
                Console.WriteLine("Or the first number is not equal to second");
            }


            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("Answer is grater than 10");
                Console.WriteLine("Or the first number is equal to second");
            }
            else
            {
                Console.WriteLine("Answer is not grater than 10");
                Console.WriteLine("And the first number is not equal to second");
            }

        }

        public static void loopsR(){
            Console.WriteLine("\nUsing loops for recursive operation\n");
            int counter = 0;
            while (counter < 10)
            {
            Console.WriteLine($"[While Loop]Hello World Counter : {counter}");
            counter++;
            }

            int cnter = 0;
            do
            {
            Console.WriteLine($"[Do While Loop]Hello World Counter : {cnter}");
            cnter++;
            } while (cnter < 10);

        }

        public static void ForLp(){
            Console.WriteLine("\nWorking with for loop\n");
            for(int counter = 0; counter < 10; counter++)
            {
            Console.WriteLine($"[For Loop]Hello World Counter : {counter}");
            }
        }

        public static void Nesloops(){
             Console.WriteLine("\nCreating nested loops\n");

            for (int row = 1; row < 11; row++)
            {
            Console.WriteLine($"Row Count {row}");
            }

            for (char column = 'a'; column < 'k'; column++)
            {
            Console.WriteLine($"Column count {column}");
            }

            for (int row = 1; row < 11; row++)
            {
            for (char column = 'a'; column < 'k'; column++)
            {
                Console.WriteLine($"Row X Column ({row}, {column})");
            }
            }
        }
        
        public static void combloop(){
            Console.WriteLine("\nCombining branches with loops\n");
            int sum = 0;
            for (int number = 1; number < 21; number++)
            {
             if (number % 3 == 0)
              {
                sum = sum + number;
              }
              }
               Console.WriteLine($"Sum is : {sum}");
        }
        }
        
  }
