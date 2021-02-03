using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BlockBusterLab
{
    public enum Genre
    {
        Comedy,
        Drama,
        Horror,
        Romance,
        Action,
        Indie,
        Adventure,
        Propaganda,
        Animation
    }
    abstract class Movie
    {

        public string Title { get; set; }
        public int RunTime { get; set; }
        public Genre Category { get; set; }
        public List<string> Scenes { get; set; }


        public Movie(string Title, int RunTime, Genre Category, List<string> Scenes)
        {
            this.Title = Title;
            this.RunTime = RunTime;
            this.Category = Category;
            this.Scenes = Scenes;
        }

        public virtual void PrintInfo(Movie m, int index)
        {
               Console.WriteLine($"     Title: {m.Title}");
               Console.WriteLine($"     Run Time: {m.RunTime} Minutes");
               Console.WriteLine($"     Genre: {m.Category}");
            
            

        }
        public static void PlayWholeMovie(List<string> Scenes)
        {
            foreach (string s in Scenes)
            {
                Console.WriteLine(s);
                Thread.Sleep(1000);

            }
        }
        public static void PrintScenes(List<string> Scenes)
        {
            foreach (string s in Scenes)
            {
                Console.WriteLine($"    {Scenes.IndexOf(s) + 1}. {s}");
            }
        }
        public abstract void Play();
        public override string ToString()
        {
            string output = "";
            output += $"Title: {Title}\n";
            output += $"Run Time: {RunTime} Minutes\n";
            output += $"Genre: {Category}\n";
            return output;
        }
    }
}