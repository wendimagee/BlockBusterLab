using System;
using System.Collections.Generic;
using System.Text;


namespace BlockBusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
            Console.WriteLine("Welcome to GC Blockbuster!\n");
            Console.WriteLine("Please select a movie from the list\n");
            //call a new blockbuster object in order to bring the movie list into existence
            BlockBuster bB = new BlockBuster();
            //list movies
            bB.PrintMovies();
            //call the getmovie method to select a movie
            Movie m = bB.GetMovie(0);
            //print selected movies info
            m.PrintInfo(m, 0);

            //m.Play();
            //^^the method is being called but no list is produced?
            //I imagine the problem is in my overwriting of ToString but i still dont understand how/why

            //bB.Checkout(movies);



        }
    }
}
