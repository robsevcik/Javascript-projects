using System;


    class Program
    {
        static void Main()
    {
        Console.WriteLine("The Tech Academy");

        Console.WriteLine("Student Daily Report");

        Console.WriteLine("what is your name?");
            string name = Console.ReadLine();

        Console.WriteLine("What course are you on?");
        int course = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What page number?");
        int page = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Do you need help with anything? True or False.");
        bool help = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("Were there any possitive experiences you'd like to share? Please give specifics");
        string experiences = Console.ReadLine();

        Console.WriteLine("How many hours did you study?");
        int hours = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");

        Console.ReadLine();
    }
}

