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

            Console.WriteLine("Please enter package width");
            int width = Convert.ToInt32(Console.ReadLine());
            if (width > 50)
            {
                Console.WriteLine("Package is to wide to be shipped via Package Express.Have a good day");
            }


            Console.WriteLine("Please enter package height");
            int height = Convert.ToInt32(Console.ReadLine());
            if (height > 50)
            {
                Console.WriteLine("Package is to tall to be shipped via Package Express.Have a good day");
            }


            Console.WriteLine("Please enter package Length");
            int length = Convert.ToInt32(Console.ReadLine());
            if (length > 50)
            {
                Console.WriteLine("Package is to long to be shipped via Package Express.Have a good day");
            }

            int Cost = ((width * height * length)* weight)/100;


           
            Console.WriteLine($"total is: ${Cost}");

        }
    }
}
