using System;
using EMPinfo;
namespace Main
{
    class Program
    {
        public static void Main(string[] args)
        {
            PermanentEmployee e1 = new PermanentEmployee("Chintan", "gamit", "05-06-2002", "05 - 01 - 2020", 60000.0, 10000, 5000, 3000);

            Console.WriteLine($"Information about First Employee:\n{e1}");

            e1.RaiseSalary(10.0);
            Console.WriteLine($"Information about First Employee after 10% raise:\n{e1}");

            PermanentEmployee e2 = new
            PermanentEmployee("Niraj", "Sheladiya", "11-12-1995", "30-05-2020", 10000.0, 2000, 1200, 8000);
            Console.WriteLine($"Inforamtion about second Employee:\n{e2}");

            e2.RaiseSalary(10.0);
            Console.WriteLine($"Inforamtion about second Employee after 10% raise:\n{ e2}");
        }
    }
}