﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    class BlockBuster
    {
        public List<Movie> movies { get; set; }
        public BlockBuster()
        {
            List<string> brickScenes = new List<string>
            {
                "Brick1","Brick2","Brick3","Brick4",
            };
            List<string> girlInterruptedScenes = new List<string>
            {
                "Winona Ryder gets institutionalized",
                "Winona Ryder meets various crazy ladies and one sane lesbian",
                "Winona and Angelina Jolie (sexy crazy lady) break out of mental institution",
                "Winona Ryder sees a lot of crazy shit and decides to go back to the hospital and seek treatment for her mental illness",
            };
            List<string> youngFScenes = new List<string>
            {
                "Young Frankenstein", "Young Frankenstein1", "Young Frankenstein2", "Young Frankenstein3",
            };
            List<string> platoonScenes = new List<string>
            {
                "Platoon1", "Platoon2", "Platoon3", "Platoon4",
            };
            List<string> clashTScenes = new List<string>
            {
                "clashT1", "clashT2", "clashT3", "clashT4",
            };
            List<string> cuttingEdgeScenes = new List<string>
            {
                "cuttingEdge1", "cuttingEdge2", "cuttingEdge3", "cuttingEdge4",
            };

            Movie a = new DVD("Platoon", 120, Genre.Drama, platoonScenes);
            Movie b = new DVD("Girl, Interrupted", 127, Genre.Drama, girlInterruptedScenes);
            Movie c = new DVD("Brick", 110, Genre.Action, brickScenes);
            Movie d = new VHS("Young Frankenstein", 102, Genre.Comedy, youngFScenes);
            Movie e = new VHS("Clash of the Titans", 118, Genre.Adventure, clashTScenes, 2);
            Movie f = new VHS("The Cutting Edge", 97, Genre.Romance, cuttingEdgeScenes, 3);

            movies = new List<Movie>();
            movies.Add(a);
            movies.Add(b);
            movies.Add(c);
            movies.Add(d);
            movies.Add(e);
            movies.Add(f);
        }
        public void PrintMovies()
        {
            foreach (Movie m in movies)
            {
                Console.WriteLine($"    {movies.IndexOf(m) + 1}. {m.Title}");
            }
            Console.WriteLine();
        }
        public void Checkout(List<Movie> movies)
        {
            PrintMovies();
            Console.WriteLine("Which movie would you like to checkout?");
            string input = Console.ReadLine();
            int userChoice = Int32.Parse(input) - 1;
            //check if userchoice is in index
            //if (userChoice > Scenes.Count || userChoice < 0)
            //    {
            //        throw new IndexOutOfRangeException();
            //    }
            //    PrintInfo(movies[userChoice]);
        }
            public Movie GetMovie(int index)
            {
                return movies[index];
            }
            // public virtual void PrintInfo(int userChoice)
            //    {
            //    for (int i = 0; i < movies.Count; i++)
            //         {
            //        if (m[] == userChoice)
            //        {
            //            Console.WriteLine($"   Title: {Title}\n    Run Time: {RunTime} Minutes\n   Genre: {Category}\n");
            //        }
            /*CheckOut() - this will call PrintMovies() and ask the user which movie they’d like to check out, 
             get an index from the user, select a movie from the list and PrintInfo() on that movie.
             The method should return the Movie object selected by the user.*/

        
    }
}
