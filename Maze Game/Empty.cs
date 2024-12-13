using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    internal class Empty:ImazeObject
    {
        public string Icon => " ";

        public bool IsSolid => false;
    }
}
