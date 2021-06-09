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
            

           int d = math.MyMethod1(numone);
            Console.WriteLine(d);
            

            Console.WriteLine("enter a number to divide by");
            int a = Convert.ToInt32(Console.ReadLine());
            



           int r = math.MyMethod2(a);
            Console.WriteLine(r);

            Console.WriteLine("enter a number to subtract");
            int c = Convert.ToInt32(Console.ReadLine());
           





           int y= math.MyMethod3(c);
            Console.WriteLine(y);

        }
    }
}
