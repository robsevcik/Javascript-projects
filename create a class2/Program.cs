using System;

namespace create_a_class2
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("enter a number to multiply by");
            int numone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter another");
            int numtwo = Convert.ToInt32(Console.ReadLine());


            math.MyMethod1(numone, numtwo);


            Console.WriteLine("enter a number to divide by");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter another");
            int b = Convert.ToInt32(Console.ReadLine());



            math.MyMethod2(a, b);


            Console.WriteLine("enter a number to subtract");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter another");
            int d = Convert.ToInt32(Console.ReadLine());





            math.MyMethod3(c,d);

        }
    }
}
