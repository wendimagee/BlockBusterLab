using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    class DVD : Movie
    {

        public DVD(string Title, int RunTime, Genre Category, List<string> Scenes)
            : base(Title, RunTime, Category, Scenes)
        {
            this.Title = Title;
            this.RunTime = RunTime;
            this.Category = Category;
            this.Scenes = Scenes;
        }
        public override void Play()
        {
            Console.WriteLine("Now Playing: " +Title);
            Console.WriteLine("What scene would you like to watch?" + (Scenes.Count + 1));
            PrintScenes(Scenes);
            Console.WriteLine("Which scene would you like to watch?");
            string input = Console.ReadLine();
            int userChoice = int.Parse(input) - 1;
            //check if userchoice is in index
            //if (userChoice > Scenes.Count || userChoice < 0)
            //{
            //    throw new IndexOutOfRangeException();
            //}
            Console.WriteLine(Scenes[userChoice]);

        }
    }
}
