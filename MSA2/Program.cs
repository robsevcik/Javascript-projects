using System;

namespace Method_Class_Submission_assignment
{
    class Program
    {
        public void Main()
        {
            class2 class2 = new();

            Console.WriteLine("enter a number to multiply by");
            int numone = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a second number, or zero");
            int numtwo = Convert.ToInt32(Console.ReadLine());

             class2.MyMethod(numone, numtwo);

             class2.MyMethod(numone:17, numtwo:5);
            

            Console.WriteLine("the other number was: "+ numtwo);

        }
    }
}
