using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    internal class Player : ImazeObject
    {

        
        internal int X {  get; set; }
        internal int Y { get; set; }
        internal bool reach {  get; set; }
        public string Icon => "@";

        public bool IsSolid => false;

       
    }
}
