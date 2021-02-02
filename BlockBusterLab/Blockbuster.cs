using System;
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
        public Movie CheckOut()
        {
            PrintMovies();
            Console.WriteLine("Please enter the number of your selection: ");
            int index = int.Parse(Console.ReadLine());
            //call the getmovie method to select a movie
            Movie m = GetMovie(index - 1);
            //print selected movies info
            m.PrintInfo(m, (index - 1));
            return m;
        }
        public Movie GetMovie(int index)
            {
                return movies[index];
            }

        
    }
}
