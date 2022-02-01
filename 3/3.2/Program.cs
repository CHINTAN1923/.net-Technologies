using System;
using StringOperation;
namespace mainProgram{
    class MainProg
    {
        public static void Main(string[] args){
               
                Console.WriteLine("\nENTER A STRING TO FIND IT'S LENGTH : ");
                String str = Console.ReadLine();
                Console.WriteLine($"\"{str}\" IS OF LENGTH : {StringOpr.Length(str)}");
                
               
                Console.WriteLine("\nENTER A SENTENCE TO FIND IT'S TYPE : ");
                String sentence = Console.ReadLine();

                if(StringOpr.isDeclarative(sentence)){
                    Console.WriteLine("IT'S A DECLARATIVE SENTENCE");
                }else if(StringOpr.isExclamatory(sentence)){
                    Console.WriteLine("IT'S A EXCLAMATORY SENTENCE");
                }else if(StringOpr.isInterrogative(sentence)){
                    Console.WriteLine("IT'S A INTERROGATIVE SENTENCE");
                }
                else{
                    Console.WriteLine("IT'S OTHER TYPE OF SENTENCE");
                }

                //3
                Console.WriteLine("\nENTER FIRST NAME AND LAST NAME HAVING SPACE BETWEEN THEM ");
                String name = Console.ReadLine();
                StringOpr.NameSwap(name);
                //4
                Console.WriteLine("\nENTER NAME : ");
                String sname = Console.ReadLine();
                StringOpr.ImpNameSwap(sname);

        }
    }
}