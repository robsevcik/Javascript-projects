using System;

namespace Method_Submission_assignment
{
    class Program
    {
        static void Main()
        {
            Math math = new();

            Console.WriteLine("enter a number to multiply by");
            int numone = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a second number, or zero");
            int numtwo = Convert.ToInt32(Console.ReadLine());


            int d = math.MyMethod1(numone, numtwo);
            Console.WriteLine("total of numbers multiplyed, times 5 = "+ d);

        }
    }
}
