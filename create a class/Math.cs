using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_a_class
{
    class Math
    {
        static void MyMethod1()
        {
            Console.WriteLine("enter a number to multiply by");
            int numone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter another");
            int numtwo = Convert.ToInt32(Console.ReadLine());
            int i = numone * numtwo;

            Console.WriteLine(i);
        }
        static void MyMethod2()
        {
            Console.WriteLine("enter a number to divide by");
            int numone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter another");
            int numtwo = Convert.ToInt32(Console.ReadLine());
            int i = numone / numtwo;

            Console.WriteLine(i);
        }
        static void MyMethod3()
        {
            Console.WriteLine("enter a number to subtract");
            int numone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter another");
            int numtwo = Convert.ToInt32(Console.ReadLine());
            int i = numone - numtwo;

            Console.WriteLine(i);
        }

    }

}
