
using Maze_Game;

namespace Main
{
    class Programe
    {
        public static void Main()
        {
            Maze maze = new Maze(40, 20);
            while (true)
            {
                maze.Draw();
                maze.movePlayer();
            }
        }
    }
}