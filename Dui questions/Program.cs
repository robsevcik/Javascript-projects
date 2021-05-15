using System;

namespace Dui_questions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI True or false?")
            bool DUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many Speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");

            bool total =  (age < 15 &&(DUI == false &&(tickets 3 <=);
            Console.WriteLine(total);

        }
    }
}
