﻿using System;

namespace Main_method_submission_assignment
{
    class Class1
    {
        private static void Main()
        {
            Math math = new();

            Console.WriteLine("enter a number to multiply by");
            int numone = Convert.ToInt32(Console.ReadLine());


            int d = math.MyMethod1(numone);
            Console.WriteLine(d);



            Math math1 = new();
           

            Console.WriteLine("enter a number to add by");
            decimal numtwo = Convert.ToInt32(Console.ReadLine());


            decimal b = math.MyMethod1(numtwo);
            Console.WriteLine(b);

            Math math2 = new();

            Console.WriteLine("enter a number to subtract by");
            string numthree = Convert.ToString(Console.ReadLine());


            int c = math.MyMethod1(numthree);
            Console.WriteLine(c);
        } 
    }
}

