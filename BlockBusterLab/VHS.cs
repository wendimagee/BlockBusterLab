using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BlockBusterLab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }
        public VHS(string Title, int RunTime, Genre Category, List<string> Scenes, int CurrentTime=0) : base(Title, RunTime, Category, Scenes)
        {
            this.CurrentTime = CurrentTime;
        }

        public static void Rewind(int CurrentTime)
        {
            CurrentTime = 0;
        }
        public override void Play()
        {
            for (int i = CurrentTime; CurrentTime < Scenes.Count; i++)
            {
                if (i == Scenes.Count)
                {
                    break;
                }
                Console.WriteLine(Scenes[i]);
                Console.WriteLine("Would you like to watch the next scene? (y/n)");
                string input2 = Console.ReadLine().Trim().ToLower();
                if (input2 == "y" && i != Scenes.Count)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("The movie has ended. Would you like to rewind?");
            string answer2 = Console.ReadLine();
            if (answer2 == "y")
            {
                Rewind(CurrentTime);
                Console.WriteLine("Would you like to watch from the beginning? (y/n)");
                string watchAgain = Console.ReadLine().ToLower().Trim();
                if (watchAgain == "y" || watchAgain == "yes")
                {
                    PlayWholeMovie(Scenes);
                }
            }
            else
            {
                Console.WriteLine("Sigh.");
            }
        }
        public override string ToString()
        {
            string output = base.ToString();
            output += $"Scenes: {Scenes}\n";;
            return output;
        }
    }
}
