using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    class Blockbuster
    {
        /*Lastly, create a class named Blockbuster that contains the following code: 
        List<Movie> Movies - this should contain at least 6 movies, 3 DVDs, 3 VHS all your choice
        
        CheckOut() - this will call PrintMovies() and ask the user which movie they’d like to check out, 
        get an index from the user, select a movie from the list and PrintInfo() on that movie.
        The method should return the Movie object selected by the user.*/

        public void ListMovies()
        {
            //make a bunch of scene lists
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
            //make movies list
            List<Movie> movies = new List<Movie>();
            DVD a = new DVD("Platoon", 120, Genre.Drama, platoonScenes);
            DVD b = new DVD("Girl, Interrupted", 127, Genre.Drama, girlInterruptedScenes);
            DVD c = new DVD("Brick", 110, Genre.Action, brickScenes);
            VHS d = new VHS("Young Frankenstein", 102, Genre.Comedy, youngFScenes, 0);
            VHS e = new VHS("Clash of the Titans", 118, Genre.Adventure, clashTScenes, 2);
            VHS f = new VHS("The Cutting Edge", 97, Genre.Romance, cuttingEdgeScenes, 3);

        }
        public void PrintMovies(List<Movie> movies)
        {
            foreach (Movie m in movies)
            {
                Console.WriteLine($"    {movies.IndexOf(m) + 1}. {m.Title}");
            }
        }
        public void Checkout(List<Movie> movies)
        {
            PrintMovies(movies);
            Console.WriteLine("Which movie would you like to checkout?");
            string input = Console.ReadLine();
            int userChoice = Int32.Parse(input) - 1;
            //check if userchoice is in index
            //if (userChoice > Scenes.Count || userChoice < 0)
            //{
            //    throw new IndexOutOfRangeException();
            //}
            //PrintInfo(movies[userChoice]);
        }
        //public void PrintInfo(List<Movie> movies, int userChoice)
        //    {
        //    for (int i = 0; i < length; i++)
        //         {
        //        if (m[] == userChoice)
        //        {
        //            Console.WriteLine($"   Title: {Title}\n    Run Time: {RunTime} Minutes\n   Genre: {Category}\n");
        //        }
            

            }

        }