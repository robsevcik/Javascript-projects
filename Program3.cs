﻿using System;

namespace income_comparrison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int rate1 = 15.00;
            Console.WriteLine(rate1);
            Console.WriteLine("Hours per week?");
            int hourly1 = 50;
            Console.WriteLine(hourly1);
            Console.WriteLine("Person2");
            Console.WriteLine("Hourly rate?");
            int rate2 = 16.75;
            Console.WriteLine(rate2);
            Console.WriteLine("Hours per week");
            int hourly2 = 35;
            Console.WriteLine("Anual salary of person 1");
            int salary1 = rate1 * hourly1;
            int salary2 = rate2 * hourly2;
            Console.WriteLine(salary1);
            Console.WriteLine("Anual salary of person 2");
            Console.WriteLine(salary2)
            Console.WriteLine("Does Person 1 make more money than person2?")
            Bool totalsalary = salary1 > salary2;
            Console.WriteLine(totalsalary);
            Console.ReadLine();



        }
    }
}
