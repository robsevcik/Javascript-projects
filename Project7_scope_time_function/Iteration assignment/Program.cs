using ImTools;
using System;
using System.Collections.Generic;

namespace Iteration_assignment
{
    class Program
    {

        private static int int1;

        static void Main(string[] args)
        {
            string[] bikes = { "Harley", "Honda", "Triumph", "Indian" };

            Console.WriteLine("what is your favorite motorcycle?");
            string userbike = Console.ReadLine();

            string[] bikes1 = bikes;
            foreach (string s in bikes1)
            {
                Console.WriteLine(userbike);
            }
            foreach (var item in bikes)
            {
                Console.WriteLine(item);
            }

            int1 i = 0;
            for (int1 = 0; int1 < bikes.Length; i++)
            {
                string input = bikes[i] + "is" + userbike;
                bikes1[i] = input;
            }

            //infinite loop//

            for (int a = 0; a < 50; a--)
            {
                Console.WriteLine("value : {0}", a);
            }
            Console.ReadLine();

            //end loop//

            //< loop//

            for (int a = 0; a < 10; a++)
            {
                Console.WriteLine("Value of i: {0}", i);
            }

            // <= loop//

            for (int y = 0; y <= 10; y = y + 2)
            {
                Console.WriteLine(i);
            }

            // list of strings//


            List<string> Pizza = new List<string>();

            Pizza.Add("pepperoni");
            Pizza.Add("xtra cheese");
            Pizza.Add("onions");
            Pizza.Add("mushrooms");
            Pizza.Add("anchovies");
            Pizza.Add("black olives");
            Pizza.Add("peppers");

            Console.WriteLine("enter a pizza topping");
            string topping = Console.ReadLine();
            Console.WriteLine(topping);

        }   

            for (int i = 0; I<Pizza.count; i ++)
            {
            if (Pizza[i] == topping)
            }
            { 
            Console.WriteLine(topping);
            break;

            }
           else
             }
            {
    Console.WriteLine("sorry thats not on the list");
                }
    
    
    Console.ReadLine();


         /////////////////////////////



        }
    }
}
