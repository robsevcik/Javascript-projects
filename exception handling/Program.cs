using System;

namespace exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a number");

                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("pick a second numbner");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("dividing the two..");
                int numberthree = numberOne / numberTwo;
                Console.WriteLine(numberOne + "  divided by" + numberTwo + "  equals" + numberthree);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("please type a whole number");
            }
            catch (DividedByZeroException ex)
            {
                Console.WriteLine("please dont divide by zero");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }
    }
}
