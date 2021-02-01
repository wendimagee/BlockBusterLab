using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    public enum Genre
    {
        Comedy,
        Horror,
        Romance,
        Kids,
        Action,
        Indie,
        Adventure,
        Propaganda,
        Animation
    }
    class Movie
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

            public override string PrintInfo(List<Movie> movies)
            {
                foreach(Movie m in movies)
            {
                string output = "";
                output += $"Title: {Title}\n";
                output += $"Run Time: {RunTime} Minutes\n";
                output += $"Genre: {Category}\n";
                return output;
            }
            }
        }
    }