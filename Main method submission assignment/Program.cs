using System;

namespace Main_method_submission_assignment
{
    class Class1
    {
        static void Main(string[] args)
        {
            Math math = new();

            Console.WriteLine("enter a number to multiply by");
            int numone = Convert.ToInt32(Console.ReadLine());


            int d = math.MyMethod1(numone);
            Console.WriteLine(d);



            Math math = new();

            Console.WriteLine("enter a number to add by");
            int numone = Convert.ToInt32(Console.ReadLine());


            int b = math.MyMethod1(numone);
            Console.WriteLine(b);

            Math math = new();

            Console.WriteLine("enter a number to subtract by");
            int numone = Convert.ToInt32(Console.ReadLine());


            int c = math.MyMethod1(numone);
            Console.WriteLine(c);
        } 
    }
}

