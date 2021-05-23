using ImTools;
using System;
using System.Collections.Generic;

namespace Iteration_assignment
{
    class Program
    {

        private static int int1;
        private static object flavor;

        static void Main(string[] args)
        {
            string[] bikes = { "harley", "honda", "triumph", "indian" };

            console.writeline("what is your favorite motorcycle?");
            string userbike = console.readline();

            string[] bikes1 = bikes;
            foreach (string s in bikes1)
            {
                console.writeline(userbike);
            }
            foreach (var item in bikes)
            {
                console.writeline(item);
            }

            int1 n = 0;
            for (int1 = 0; int1 < bikes.length; n++)
            {
                string input = bikes[n] + "is" + userbike;
                bikes1[n] = input;
            }

            //infinite loop//

            for (int a = 0; a < 50; a--)
            {
                console.writeline("value : {0}", a);
            }
            console.readline();

            //end loop//

            //<loop//

            for (int a = 0; a < 10; a++)
            
               console.writeline("value of i: {0}", n);
         

             <= loop//

            for (int y = 0; y <= 10; y = y + 2)
            {
                console.writeline(n);
           }

            //list of strings//




            ////////////////part 5/////////////


            list<string> cookie = new list<string>();

            cookie.add("chocolate_chip");
            cookie.add("peanutbutter");
            cookie.add("snickerdoodle");
            cookie.add("macadamin");
            cookie.add("snickerdoodle");

            console.writeline("what is your favorite cookie?");
            string index = console.readline();
            for (int w = 0; w < cookie.count; w++)
            {
                if (cookie[w] == index)
                {
                    console.writeline("match found at index " + w);
                }
                else
                {
                    console.writeline("sorry thats not the right one");

                }


            }



            ////////part 6////////////////////
            ///

            List<string> fruit = new List<string>();

            fruit.Add("apple");
            fruit.Add("orange");
            fruit.Add("apple");
            fruit.Add("grapes");
            fruit.Add("banana");
            fruit.Add("apple");

            List<string> fruitCopy = new List<string>();

            foreach (var item in fruit)
            {
            foreach (var item2 in fruitCopy)
                { 
                 if (item == item2)
                    {
                        Console.WriteLine(item + " has appered before.");
                    }
                }

                fruitCopy.Add(item);

                }


        }
    }
}
