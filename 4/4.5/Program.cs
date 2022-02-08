using System;
using method;

class Program
{
    static void Main()
    {
        var tempRecord = new TempRecord();


        tempRecord[3] = 58.3F;
        tempRecord[5] = 60.1F;

    
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Element #{i} = {tempRecord[i]}");
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

}