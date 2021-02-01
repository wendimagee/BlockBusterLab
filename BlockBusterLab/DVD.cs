using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    class DVD : Movie
    {
        public DVD(string Title, int RunTime, Genre Category, List<string> Scenes): base(Title, RunTime, Category, Scenes)
        {

        }
    }
}
