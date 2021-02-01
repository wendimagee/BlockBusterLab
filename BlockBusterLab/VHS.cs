using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    class VHS: Movie
    {
        int currentTime = 0;
        public VHS(string Title, int RunTime, Genre Category, List<string> Scenes, int currentTime) : base(Title, RunTime, Category, Scenes)
        {
            this.Title = Title;
            this.RunTime = RunTime;
            this.Category = Category;
            this.Scenes = Scenes;
            this.currentTime = currentTime;
        }

        public void Rewind(int currentTime)
        {
            currentTime = 0;
        }
        public void Play(int CurrentTime)
        {
            Console.WriteLine(Scenes[CurrentTime]);
            CurrentTime++;
        }
    }
}
