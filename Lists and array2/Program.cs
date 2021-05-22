using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_and_array2
{
    class Program
    {
        static void Main()
        {

            int[] numArray = new int[5];
            numArray[0] = 5;
            numArray[1] = 2;
            numArray[2] = 10;
            numArray[3] = 200;
            numArray[4] = 5000;




            Console.WriteLine("Choose an index");
            int num = Convert.ToInt32(Console.ReadLine());


            if (num >= 0 && num < 4)
            {
                Console.WriteLine(numArray[num]);
            }
            else
            {
                Console.WriteLine("Sorry thats not one");
            }

            string[] stringArray = new string[4];
            stringArray[0] = "chevy";
            stringArray[1] = "ford";
            stringArray[2] = "BMW";
            stringArray[3] = "Volvo";


            Console.WriteLine("Choose an index");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= 0 && num1 < 3)
            {
                Console.WriteLine(stringArray[num1]);
            }
            else
            {
                Console.WriteLine("Sorry thats not one");
            }

            List<string> breakfast = new List<string>();

            breakfast.Add("eggs");
            breakfast.Add("bacon");
            breakfast.Add("waffles");


            Console.WriteLine("Choose an index");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(breakfast[index]);




        }
    }
}
