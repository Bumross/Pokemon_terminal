namespace Pokemon
{
    class Game
    {
        public WindowManager windowManager;
        public int Row;

        public Game(WindowManager windowManager)
        {
            this.windowManager = windowManager;
            this.Row = 0;
        }

        public void Start()
        {
            windowManager.SetWindow(new Title());
            windowManager.DisplayWindow(0);
            Console.ReadKey();
            windowManager.SetWindow(new MainManu());

            while (true)
            {
                windowManager.DisplayWindow(this.Row);
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    this.Row -= 1;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    this.Row += 1;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }

            } 
        }

    }
}