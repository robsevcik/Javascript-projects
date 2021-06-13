using System;

namespace Method_Submission_assignment
{
    class Program
    {
        public static void Main()
        {
            Math math = new();

            Console.WriteLine("enter a number to multiply by");
            int numone = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a second number, or zero");
            int numtwo = Convert.ToInt32(Console.ReadLine());


            int d = math.MyMethod(numone);
            Console.WriteLine("here is your number, times 5 = "+ d);

            Console.WriteLine("the other number was: "+ numtwo);

        }
    }
}
