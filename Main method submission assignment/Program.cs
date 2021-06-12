using System;

namespace Main_method_submission_assignment
{
    class Class1
    {
        static void Main(string[])
        {
            Math math = new();

            Console.WriteLine("enter a number to multiply by");
            int numone = Convert.ToInt32(Console.ReadLine());


            int d = math.MyMethod1(numone);
            Console.WriteLine(d);



            Math math1 = new();
           

            Console.WriteLine("enter a number to add by");
            double numtwo = Convert.ToDouble(Console.ReadLine());


            double b = math.MyMethod1(numtwo);
            Console.WriteLine(b);

            Math math2 = new();

            Console.WriteLine("enter a number to subtract by");
            string numthree = Convert.ToInt32(Console.ReadLine());


            string c = math.MyMethod1(numthree);
            Console.WriteLine(c);
        } 
    }
}

