using System;

namespace Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine(" What is your name?");
            String userName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("what course are you one?");
            String course = Convert.ToString(Console.ReadLine());

            Console.WriteLine("What page number");
            int page = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer true or false?");
            String help = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            String experiences = Convert.ToString(Console.ReadLine());

            Console.WriteLine(" Is there any feed back yu would like to share? Please be specific.");
            String feedback = Convert.ToString(Console.ReadLine());

            Console.WriteLine("How many hours did you study today?");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly.Have a great day!");
            Console.ReadLine();


        }
    }
}
