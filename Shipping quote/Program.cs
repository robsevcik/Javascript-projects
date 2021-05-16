using System;

namespace Shipping_quote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below");

            Console.WriteLine("Please enter package weight");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package is to heavy to be shipped via Package Express.Have a good day");
            }
            else
                }
        Console.WriteLine("Please enter package width");
            int width = Convert.ToInt32(Console.ReadLine());



        Console.WriteLine("Please enter package height");
            int height = Convert.ToInt32(Console.ReadLine());



        Console.WriteLine("Please enter package Length");
            int length = Convert.ToInt32(Console.ReadLine());
           
        if ((width + height + length) > 50);
            {
            Console.Writeline("Sorry package is to large for shipping.");
            }
            else
            {
             int Cost = ((width * height * length)* weight)/100);

              Console.WriteLine($"total is: ${Cost}");

        }
    }
}
