

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
            LoadMainPage();

        }

        public void LoadMainPage()
        {
            bool exit = false;
            while (!exit)
            {
                windowManager.SetWindow(new MainManu());
                ChooseRow(3);

                if (this.Row == 0)
                {
                    exit = true;
                }
                else if (this.Row == 1)
                {
                windowManager.SetWindow(new Credits());
                windowManager.DisplayWindow(0);
                Console.ReadKey();
                }
                else if (this.Row == 2)
                {
                    break;
                }
            }
        }

        public void ChooseRow(int rows)
        {
            this.Row = 0;
            bool exit = false;
            while (!exit)
            {
                this.Row = this.Row % rows;
                windowManager.DisplayWindow(this.Row);
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (this.Row == 0){this.Row = (rows - 1);}
                    else {this.Row -= 1;}
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    this.Row += 1;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    exit = true;
                }
            }
        }

    }
}