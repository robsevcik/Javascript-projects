using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_a_class2
{
    class Math
    {
        public void MyMethod1(int numone, int numtwo)
        {
            
            int i = numone * numtwo;

            Console.WriteLine(i);
        }
        public void MyMethod2(int numone, int numtwo)
        {
           
            int b = numone / numtwo;

            Console.WriteLine(b);
        }
        public void MyMethod3(int numone, int numtwo)
        {
           
            int d = numone - numtwo;

            Console.WriteLine(d);
        }

    }

}


