using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace exception_handling
{
    class Program
    {
        public static bool Result { get; private set; }

        static void Main(string[] args)
        {
            try
            {
                List<int> intlist = new List<int>();
                intlist.Add(4);
                intlist.Add(3);
                intlist.Add(7);


                Console.WriteLine("Pick a number to divide each number by");

                int numberOne = Convert.ToInt32(Console.ReadLine());

                foreach (int number in intlist)
                {
                    int v = number / numberOne;
                    int result1 = v;
                }
                Console.WriteLine(Result);

                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("please type a whole number");
            }
            catch (DividedByZeroException)
            {
                Console.WriteLine("please dont divide by zero");
            }
            catch (Exception)
            {

                Console.WriteLine("no string please");
           

                Console.WriteLine("leaving the catch");
            }
            Console.ReadLine();
            
        }
    }
}
