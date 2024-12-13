using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    internal class Food:ImazeObject
    {
        internal int X { get; set; }
        internal int Y { get; set; }

        public string Icon => "$";

        public bool IsSolid => false;

        Random randomX = new Random();
        Random randomY = new Random();

        internal Food(ref Player player, int Width, int Height)
        {
            Y = randomY.Next(1, Height - 2);
            X = randomX.Next(1, Width - 2);
            while (X % 3 == 0 || X == player.X)
            {
                X = randomX.Next(1, Width);
            }
            while (Y % 3 == 0 || Y == player.Y)
            {
                Y = randomY.Next(1, Height);
            }
        }
        internal void changePosition(ref Player player, int Width, int Height)
        {
            if (X == player.X && Y == player.Y)
            {
                Console.Clear();
                player.reach = false;
                Y = randomY.Next(2, Height - 1);
                X = randomX.Next(2, Width - 1);
                while (X % 3 == 0 || X == player.X)
                {
                    X = randomX.Next(1, Width);
                }
                while (Y % 3 == 0 || Y == player.Y)
                {
                    Y = randomY.Next(1, Height);
                }
            }
        }
    }
}
