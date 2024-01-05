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
        public GraphicsManager GraphicsManager;
        public List<IPokemon> Pokemons; //Pokemons existing in game
        public PokemonFactory pokemonFactory;

        public Game()
        {
            this.windowManager = WindowManager.Instance;
            this.Row = 0;
            this.pokeGraphics = new PokeGraphics();
            this.windowsGraphics = new WindowsGraphics();
            this.Exit = false;
            this.Player = new Trainer();
            this.GraphicsManager = new GraphicsManager();
            this.Pokemons = new List<IPokemon>();
            this.pokemonFactory = new PokemonFactory();

        }


        public void Start()
        {
            windowManager.SetWindow(new Title());
            windowManager.DisplayWindow(0, windowsGraphics.MainLogo, Player, windowsGraphics.EmptyOption);
            Console.ReadKey();
            LoadMainPage();

            OpenGame();
        }

        public void OpenGame()
        {
            GraphicsManager.DoOpeningOakSpeech(this.Player);
            SpawnInRoom();
            DownStairs();
            GraphicsManager.DoOakPokemonSelect(this.Player);
            ChooseStarterPokemon();
            
        }


        public void LoadMainPage()
        {
            while (!this.Exit)
            {
                windowManager.SetWindow(new Menu());
                ChooseRow(3, windowsGraphics.MainMenu, windowsGraphics.EmptyOption);

                if (this.Row == 0)
                {
                    this.Exit = true;
                }
                else if (this.Row == 1)
                {
                windowManager.SetWindow(new Credits());
                windowManager.DisplayWindow(0, windowsGraphics.Credits, Player, windowsGraphics.EmptyOption);
                Console.ReadKey();
                }
                else if (this.Row == 2)
                {
                    this.ExitGame();
                }
            }
            this.Exit = false;
        }


        public void SpawnInRoom()
        {
            while (!this.Exit)
            {
                windowManager.SetWindow(new Room());
                ChooseRow(2, windowsGraphics.MyRoom, windowsGraphics.ActionMenus["room"]);

                if (this.Row == 0)
                {
                    this.Exit = true;
                }
                else if (this.Row == 1)
                {
                }
            }
            this.Exit = false;
        }

        public void DownStairs()
        {
            while (!this.Exit)
            {
                windowManager.SetWindow(new Room());
                ChooseRow(3, windowsGraphics.KitchenRoom, windowsGraphics.ActionMenus["livingRoom"]);

                if (this.Row == 0)
                {
                    this.Exit = true;
                }
                else if (this.Row == 1)
                {
                }
            }
            this.Exit = false; 
        }

        public void ChooseStarterPokemon()
        {
            CreatePokemon(1, "starter");
            CreatePokemon(4, "starter");
            CreatePokemon(7, "starter");

            while (!this.Exit)
            {
                windowManager.SetWindow(new Menu());
                ChooseRow(3, windowsGraphics.StarterPokemonChoosing, windowsGraphics.ChoosedPokemon);

                if (this.Row == 0)
                {
                    GraphicsManager.RenderOakSpeech(this.Row, this.Player, pokeGraphics.CharmanderGraphics, windowsGraphics.ChoosedPokemon);
                    System.Console.ReadKey();
                                    foreach (IPokemon pokemon in this.Pokemons)
                {Console.WriteLine(pokemon.GetId());}
                    System.Console.ReadKey();
                }
                else if (this.Row == 1)
                {
                    GraphicsManager.RenderOakSpeech(this.Row, this.Player, pokeGraphics.BulbasaurGraphics, windowsGraphics.ChoosedPokemon);
                    System.Console.ReadKey();
                }
                else if (this.Row == 2)
                {
                    GraphicsManager.RenderOakSpeech(this.Row, this.Player, pokeGraphics.SquirtleGraphics, windowsGraphics.ChoosedPokemon);
                    System.Console.ReadKey();
                }
            }
        }

        public void ExitGame()
        {
            windowManager.SetWindow(new Exit());
            windowManager.DisplayWindow(0, windowsGraphics.MainLogo, Player, windowsGraphics.EmptyOption);
            Console.ReadKey();
            System.Environment.Exit(0);
        }


        public void ChooseRow(int rows, List<string> window, List<string> options)
        {
            this.Row = 0;
            bool exit = false;
            while (!exit)
            {
                this.Row = this.Row % rows;
                windowManager.DisplayWindow(this.Row, window, Player, options);
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
                else if (key.Key == ConsoleKey.Escape)
                {
                    ExitGame();
                }
            }
        }

        public void CreatePokemon(int ID, string type)
        {
            this.Pokemons.Add(pokemonFactory.CreatePokemon(ID));
        }
    }
}