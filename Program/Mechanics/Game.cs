namespace Poke
{
    class Game
    {
        public WindowManager windowManager;
        public int Row;
        public bool Exit;
        public PokeGraphics pokeGraphics;
        public WindowsGraphics windowsGraphics;
        public Trainer Player;
        public Trainer Rival;

        public Game()
        {
            this.windowManager = new WindowManager();
            this.Row = 0;
            this.pokeGraphics = new PokeGraphics();
            this.windowsGraphics = new WindowsGraphics();
            this.Exit = false;
            this.Player = new Trainer();
            this.Rival = new Trainer();
        }


        public void Start()
        {
            windowManager.SetWindow(new Title());
            windowManager.DisplayWindow(0, windowsGraphics.MainLogo);
            Console.ReadKey();
            LoadMainPage();

            StartGame();
        }


        public void LoadMainPage()
        {
            while (!this.Exit)
            {
                windowManager.SetWindow(new MainManu());
                ChooseRow(3);

                if (this.Row == 0)
                {
                    this.Exit = true;
                }
                else if (this.Row == 1)
                {
                windowManager.SetWindow(new Credits());
                windowManager.DisplayWindow(0, windowsGraphics.Credits);
                Console.ReadKey();
                }
                else if (this.Row == 2)
                {
                    Console.WriteLine(this.Row);
                    windowManager.SetWindow(new Exit());
                    windowManager.DisplayWindow(0, windowsGraphics.MainLogo);
                    Console.ReadKey();
                    break;
                }
            }
            this.Exit = false;
        }


        public void StartGame()
        {
            int counter = 0;
            string playerName = "";
            string rivalName = "";
            //Prof Oak intro:
            while (!this.Exit)
            {
            RenderOakSpeech(counter);
            if (counter != 6 & counter != 9) {Console.ReadKey();}
            else if (counter == 6)
            {
                string input = Console.ReadLine();
                if (input != null){playerName = input;}
                else {playerName = "Ashe";}
                this.Player.SetName(playerName);

            }
            else if (counter == 9)
            {
                string input = Console.ReadLine();
                if (input != null){rivalName = input;}
                else {rivalName = "Red";}
                this.Rival.SetName(rivalName);
            }
            counter += 1;
            }

            
        }

        public void RenderOakSpeech(int row)
        {
            windowManager.SetWindow(new OakSpeech());
            windowManager.DisplayWindow(row, windowsGraphics.CombineLists(windowsGraphics.ProfOak, windowsGraphics.ProfOakSpeechIntro));
            }

        public void ChooseRow(int rows)
        {
            this.Row = 0;
            bool exit = false;
            while (!exit)
            {
                this.Row = this.Row % rows;
                windowManager.DisplayWindow(this.Row, windowsGraphics.MainMenu);
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