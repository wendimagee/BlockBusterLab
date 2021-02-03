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
                //watch whole movie or look at scene menu?
                Console.WriteLine("     1. Play whole movie");
                Console.WriteLine("     2. Scene Menu");
                Console.WriteLine("Please enter your menu choice (1/2)");
                string menuChoice = Console.ReadLine().Trim().ToLower();
                if(menuChoice == "2")
                {
                    Console.WriteLine("What scene would you like to watch?");
                    PrintScenes(Scenes);
                    Console.WriteLine("Which scene would you like to watch?(0 - " + (Scenes.Count) + ")");
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
                    if (answer == "y")
                    {
                        Play();
                    }
                }
                else if(menuChoice == "1")
                {
                    PlayWholeMovie(Scenes);
                }
                else
                {
                    throw new IndexOutOfRangeException();
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
