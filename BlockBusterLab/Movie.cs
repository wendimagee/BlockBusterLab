using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    class Movie
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
            public Genre Genre { get; set; }

            public Movie(string Title, int RunTime, Genre Genre)
            {
                this.Title = Title;
                this.RunTime = RunTime;
                this.Genre = Genre;
            }

            public override string ToString()
            {
                string output = "";
                output += $"Title: {Title}\n";
                output += $"Run Time: {RunTime} Minutes\n";
                output += $"Genre: {Genre}\n";
                return output;
            }
        }
    }

}
}
