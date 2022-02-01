using System;

namespace StringOperation{
     
     class StringOpr
     {
      
         
        public static int Length(string s){
            return s.Length;
        }

        public static bool isDeclarative(string s){
            return s[s.Length-1] == '.';
        }
        public static bool isExclamatory(string s){
           return s[s.Length-1] == '!';
        }

        public static bool isInterrogative(string s){
            return s[s.Length-1] == '?';
        }

        public static void NameSwap(string s){
            string[] arr = s.Split(" ");
            Console.WriteLine($"THE NAME YOU HAVE ENTERED : \"{arr[1]},{arr[0]}\"");
        }

        public static void ImpNameSwap(string s){
            string[] arr = s.Split(" ");
            if(arr.Length == 1){
                Console.WriteLine($"THE NAME YOU HAVE ENTERED : \"{arr[0]}\"");
            }else{
                Console.WriteLine($"THE NAME YOU HAVE ENTERED : \"{arr[1]},{arr[0]}\"");
            }

        }

     }

}