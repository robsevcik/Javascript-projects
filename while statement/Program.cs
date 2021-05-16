using System;

namespace while_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;

            while (isGuessed) ;
            {
                Console.WriteLine("Guess again please");



                do
                {
                    switch (number)
                    {

                        default:
                            Console.WriteLine("you are wrong");
                            Console.WriteLine("guess a number");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 62:
                            Console.WriteLine("you guessed 62, try again");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;



                        case 5:
                            Console.WriteLine("you guessed the number 5! Correct!");
                            isGuessed = true;
                            break;
                    }

                }

                while (!isGuessed);

                string v = Console.ReadLine(); ;
            }
        }
    }
    }

