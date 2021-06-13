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

            Console.WriteLine("enter a second number, or it will be zero");
           string stringNumTwo = Console.ReadLine();

            if (stringNumTwo == "")
            {

                int d = math.MyMethod(numone);
                Console.WriteLine("total first number multiplyed, times 5 = " + d);
            }
            else
            {
                int c = math.MyMethod1(numone, numtwo);
                Console.WriteLine("total of both numbers multiplyed, times 5 = " + c);
            }
        }
    }
}
