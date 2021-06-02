using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_a_class2
{
    class Math
    {
        public void MyMethod1()
        {
            Console.WriteLine("enter a number to multiply by");
            int numone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter another");
            int numtwo = Convert.ToInt32(Console.ReadLine());
            int i = numone * numtwo;

            Console.WriteLine(i);
        }
        public void MyMethod2()
        {
            Console.WriteLine("enter a number to divide by");
            int numone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter another");
            int numtwo = Convert.ToInt32(Console.ReadLine());
            int b = numone / numtwo;

            Console.WriteLine(b);
        }
        public void MyMethod3()
        {
            Console.WriteLine("enter a number to subtract");
            int numone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter another");
            int numtwo = Convert.ToInt32(Console.ReadLine());
            int d = numone - numtwo;

            Console.WriteLine(d);
        }

    }

}


