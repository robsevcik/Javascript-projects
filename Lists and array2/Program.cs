using System;
using System.Linq;

namespace Lists_and_array2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numArray = new int[5];
            numArray[0] = 5;
            numArray[1] = 2;
            numArray[2] = 10;
            numArray[3] = 200;
            numArray[4] = 5000;




            Console.WriteLine("Choose an index");
            int num =Convert.ToInt32(Console.ReadLine());


            if (numArray.Contains(num))
                Console.WriteLine(numArray[num]);

            else
                Console.WriteLine("Sorry thats not one");


            string[] stringArray = new string[4];
            stringArray[0] = "chevy";
            stringArray[1] = "ford";
            stringArray[2] = "BMW";
            stringArray[3] = "Volvo";


            Console.WriteLine("Choose an index");
            int num1 = Convert.ToInt32(Console.ReadLine());

          if (stringArray.Contains(num1))
                Console.WriteLine(stringArray[num1]);

            else
                Console.WriteLine("Sorry thats not one");



        }
    }
}
