using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    class DVD : Movie
    {
        public DVD(string Title, int RunTime, Genre Category, List<string> Scenes): base(Title, RunTime, Category, Scenes)
        {
            /*Create a child of Movie named DVD with the following code: 
            A method called Play() that takes no parameters and is void that will ask 
            the user what scene they’d like to watch, print all the available scenes, 
            and allow the user to select a scene from the list and print it out.*/
        }
        public void Play()
        {
            Console.WriteLine("What scene would you like to watch?");
            PrintScenes(Scenes);
            Console.WriteLine("Which scene would you like to watch?");
            string input = Console.ReadLine();
            int userChoice = Int32.Parse(input) - 1;
            //check if userchoice is in index
            //if (userChoice > Scenes.Count || userChoice < 0)
            //{
            //    throw new IndexOutOfRangeException();
            //}
            Console.WriteLine(Scenes[userChoice]);

        }
    }
}
