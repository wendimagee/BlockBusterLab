using System;
using System.Collections.Generic;
using System.Text;

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
            //A method called Play() that plays the scene at the current time and then increments CurrentTime. 
            Console.WriteLine(Scenes[CurrentTime]);
            if (CurrentTime +1 <= Scenes.Count)
                {
                CurrentTime++;
                }
            else if(CurrentTime + 1 > Scenes.Count)
            {
                Console.WriteLine("End of movie. Would you like to rewind the movie?");
                string answer2 = Console.ReadLine();
                if (answer2 == "y")
                {
                    Rewind(CurrentTime);
                }
            }
            else
            {
                Console.WriteLine("Tape must be rewound before you can watch. Rewind now? (y/n)");
                string input2 = Console.ReadLine();
                if (input2 == "y")
                {
                    Rewind(CurrentTime);
                }
            }

            string input = "y";
            while (input == "y")
            {
                Console.WriteLine("Would you like to watch the next scene?");
                input = Console.ReadLine().Trim().ToLower();

                if (input == "y" || input == "yes")
                { 
                    
                    Play(); 
                }


                    //    try
                    //    {

                    //        Console.WriteLine(Scenes[CurrentTime]);
                    //        if (CurrentTime < Scenes.Count + 1)
                    //        {
                    //            CurrentTime++;
                    //        }
                    //        else
                    //        {
                    //            Console.WriteLine("Tape must be rewound before you can watch. Rewind now? (y/n)");
                    //            string input3 = Console.ReadLine();
                    //            if (input3 == "y")
                    //            {
                    //                Rewind(CurrentTime);
                    //            }
                    //        }
                    //    }
                    //    catch
                    //    {
                    //        Console.WriteLine("Tape must be rewound before you can watch. Rewind now? (y/n)");
                    //        string input3 = Console.ReadLine();
                    //        if (input3 == "y")
                    //        {
                    //            Rewind(CurrentTime);
                    //            Play();
                    //        }
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
