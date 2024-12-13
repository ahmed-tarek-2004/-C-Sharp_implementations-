using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    internal class Walls : ImazeObject
    {
        public string Icon => "#";

        public bool IsSolid => true;
    }
}
