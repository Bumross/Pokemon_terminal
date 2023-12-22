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

        public Game()
        {
            this.windowManager = new WindowManager();
            this.Row = 0;
            this.pokeGraphics = new PokeGraphics();
            this.windowsGraphics = new WindowsGraphics();
            this.Exit = false;
            this.Player = new Trainer();
        }


        public void Start()
        {
            windowManager.SetWindow(new Title());
            windowManager.DisplayWindow(0, windowsGraphics.MainLogo, Player);
            Console.ReadKey();
            LoadMainPage();

            StartGame();
        }

        public void StartGame()
        {
            DoOpeningOakSpeech();
            SpawnInRoom();

            
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
                windowManager.DisplayWindow(0, windowsGraphics.Credits, Player);
                Console.ReadKey();
                }
                else if (this.Row == 2)
                {
                    Console.WriteLine(this.Row);
                    windowManager.SetWindow(new Exit());
                    windowManager.DisplayWindow(0, windowsGraphics.MainLogo, Player);
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }
            this.Exit = false;
        }

        public void DoOpeningOakSpeech()
        {
            int counter = 0;
            string playerName = "";
            string rivalName = "";
            while (!this.Exit)
            {
            if (counter < 3){RenderOakSpeech(counter, this.Player, windowsGraphics.ProfOak);}
            if (2 < counter & counter < 6){RenderOakSpeech(counter, this.Player, windowsGraphics.TitlePokemon);}
            if (5 < counter & counter < 8){RenderOakSpeech(counter, this.Player, windowsGraphics.Me);}
            if (7 < counter & counter < 11){RenderOakSpeech(counter, this.Player, windowsGraphics.Rival);}
            if (counter > 10){RenderOakSpeech(counter, this.Player, windowsGraphics.Me);}

            if (counter != 6 & counter != 9) {Console.ReadKey();}
            else if (counter == 6)
            {
                string? input = Console.ReadLine();
                if (input != ""){playerName = input;}
                else {playerName = "Ashe";}
                this.Player.SetName(playerName);

            }
            else if (counter == 9)
            {
                string? input = Console.ReadLine();
                if (input != ""){rivalName = input;}
                else {rivalName = "Red";}
                this.Player.SetRivalName(rivalName);
            }

            counter += 1;
            if (counter == windowsGraphics.ProfOakSpeechIntro.Count){this.Exit = true;}
            }
        }

        public void RenderOakSpeech(int row, Trainer Player, List<string> visual)
        {
            windowManager.SetWindow(new OakSpeech());
            windowManager.DisplayWindow(row, windowsGraphics.CombineLists(visual, windowsGraphics.ProfOakSpeechIntro), Player);
            }

        public void SpawnInRoom()
        {
            windowManager.SetWindow(new Room());
            windowManager.DisplayWindow(0, windowsGraphics.CombineLists(windowsGraphics.MyRoom, windowsGraphics.miniMe), Player);
        }

        public void ChooseRow(int rows)
        {
            this.Row = 0;
            bool exit = false;
            while (!exit)
            {
                this.Row = this.Row % rows;
                windowManager.DisplayWindow(this.Row, windowsGraphics.MainMenu, Player);
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