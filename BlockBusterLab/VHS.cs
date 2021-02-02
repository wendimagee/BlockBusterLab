using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }
        public VHS(string Title, int RunTime, Genre Category, List<string> Scenes, int currentTime=0) : base(Title, RunTime, Category, Scenes)
        {
            this.CurrentTime = currentTime;
        }

        public static void Rewind(int currentTime)
        {
            currentTime = 0;
        }
        public override void Play()
        {
            Console.WriteLine(Scenes[CurrentTime]);
            if (CurrentTime < Scenes.Count + 1)
            {
                CurrentTime++;
            }
            else
            {
                Console.WriteLine("Tape must be rewound before you can watch. Rewind now? (y/n)");
                //    string input = Console.ReadLine();
                //    if(input == "y")
                //    {
                //        Rewind(Movie.CurrentTime);
                //    }
                //}
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
