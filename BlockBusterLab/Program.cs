using System;
using System.Collections.Generic;
using System.Text;


namespace BlockBusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goAgain = true;
            while (goAgain)
            {
                List<Movie> movies = new List<Movie>();
                Console.WriteLine("Welcome to GC Blockbuster!\n");
                Console.WriteLine("Please select a movie from the list\n");
                //call a new blockbuster object in order to bring the movie list into existence
                BlockBuster bB = new BlockBuster();
                Movie n = bB.CheckOut();
                Console.WriteLine("Do you want to watch the movie?(y/n)");
                string input = Console.ReadLine().Trim().ToLower();
                if(input == "y" || input =="yes")
                {
                    n.Play();
                }
                try
                {
                    Console.WriteLine("\n\nWould you like to continue?(y/n)");
                    char answer = char.Parse(Console.ReadLine());
                    if (char.ToLower(answer) == 'y')
                    {
                        goAgain = true;
                    }
                    else
                    {
                        Console.WriteLine("Have a nice day!");
                        goAgain = false;
                    }
                }
                catch
                {
                    Console.WriteLine(@"Please enter a ""y"" or an ""n"" ");
                    Console.WriteLine();
                }

            }

        }
    }
}
