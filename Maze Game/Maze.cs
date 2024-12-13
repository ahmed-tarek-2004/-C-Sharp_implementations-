using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    internal class Maze
    {
        int Width;
        int Height;
        Player player;
        Food food;
        ImazeObject[,] ImazeObject;
        public Maze(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
            ImazeObject = new ImazeObject[Width, Height];
            player = new Player() { X = 1, Y = 1, reach = false };
            food = new Food(ref player, Width, Height);
        }
        public void Draw()
        {
            Console.Clear();
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {

                    if (x == 0 || y == 0 || x == Width - 1 || y == Height - 1)
                    {
                        ImazeObject[x, y] = new Walls();
                        Console.Write(ImazeObject[x, y].Icon);
                    }
                    else if (x % 3 == 0 && y % 3 == 0)
                    {
                        ImazeObject[x, y] = new Walls();
                        Console.Write(ImazeObject[x, y].Icon);
                    }
                    else if (x == food.X && y == food.Y && player.reach == false)
                    {
                        ImazeObject[x, y] = new Food(ref player, Width, Height);
                        Console.Write(ImazeObject[x, y].Icon);
                    }
                    else if (x == player.X && y == player.Y)
                    {
                        Console.Write(player.Icon);
                    }
                    else
                    {
                        ImazeObject[x, y] = new Empty();
                        Console.Write(ImazeObject[x, y].Icon);
                    }
                }
                Console.WriteLine(" ");
            }
        }
        public void movePlayer()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            ConsoleKey mykey = key.Key;
            switch (mykey)
            {
                case ConsoleKey.UpArrow:
                    updatePosition(0, -1);
                    break;
                case ConsoleKey.DownArrow:
                    updatePosition(0, 1);
                    break;
                case ConsoleKey.RightArrow:
                    updatePosition(1, 0);
                    break;
                case ConsoleKey.LeftArrow:
                    updatePosition(-1, 0);
                    break;
            }
        }
        void updatePosition(int newX, int newY)
        {
            int X = player.X + newX;
            int Y = player.Y + newY;
            if (player.X + newX != Width && player.Y + newY != Height && player.X + newX > 0 && player.Y + newY > 0 && ImazeObject[X, Y].IsSolid == false)
            {
                player.X = X;
                player.Y = Y;
                if (player.X == food.X && player.Y == food.Y)
                {
                    player.reach = true;
                    food.changePosition(ref player, Width, Height);
                }
            }
        }
    }
}
