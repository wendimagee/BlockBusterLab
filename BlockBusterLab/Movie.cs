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

            public string PrintInfo(List<Movie> movies)
            {
            string output = "";
            foreach (Movie m in movies)
            {
                output += $"Title: {Title}\n";
                output += $"Run Time: {RunTime} Minutes\n";
                output += $"Genre: {Category}\n";
            }
                return output;
                
            }
        }
    }