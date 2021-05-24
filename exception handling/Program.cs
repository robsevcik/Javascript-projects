using System;

namespace exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                list<string> intlist = new list<string>();
                intlist.Add(4);
                intlist.Add(3);
                intlist.Add(7);
               

                Console.WriteLine("Pick a number do dived each number by");

                int numberOne = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("pick a second numbner");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("dividing the two..");
                int numberthree = numberOne / numberTwo;
                Console.WriteLine(numberOne + "  divided by" + numberTwo + "  equals" + numberthree);
                int numberthree = numberTwo / numberTwo;
                Console.WriteLine(numberOne + "  divided by" + numberTwo + "  equals" + numberFour);
                int numberthree = numberTwo / numberThree;
                Console.WriteLine(numberOne + "  divided by" + numberTwo + "  equals" + numberFive);
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
