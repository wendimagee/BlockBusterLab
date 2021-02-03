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
            try
            {
                Console.WriteLine("Now Playing: " + Title);
                Console.WriteLine("What scene would you like to watch?");
                PrintScenes(Scenes);
                Console.WriteLine("Which scene would you like to watch?(0 - " + (Scenes.Count)+ ")");
                string input = Console.ReadLine();
                int userChoice = int.Parse(input) - 1;
                //check if userchoice is in index
                if (userChoice > Scenes.Count || userChoice < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                Console.WriteLine(Scenes[userChoice]);
                Console.WriteLine("Would you like to watch another scene?");
                string answer = Console.ReadLine().Trim().ToLower();
                if(answer == "y")
                {
                    Play();
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch
            {
                Console.WriteLine("Something went wrong, please try again");
            }
        }
    }
}
