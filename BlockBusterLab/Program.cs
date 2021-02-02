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
                //list movies
                bB.PrintMovies();
                Console.WriteLine("Please enter the number of your selection: ");
                

                //m.Play();
                //^^the method is being called but no list is produced?
                //I imagine the problem is in my overwriting of ToString but i still dont understand how/why

                //bB.Checkout(movies);

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
