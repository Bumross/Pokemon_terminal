using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowManager windowManager = new WindowManager();
            Game game = new Game(windowManager);

            game.Start();
        }
    }
}