using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    class VHS: Movie
    {
        public VHS(string Title, int RunTime, Genre Category, List<string> Scenes, int CurrentTime) : base(Title, RunTime, Category, Scenes)
        {

        }

        public void Rewind(int currentTime)
        {
            currentTime = 0;
        }
    }
}
