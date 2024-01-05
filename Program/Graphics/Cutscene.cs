namespace Poke
{
    class GraphicsManager
    {
        public int Row;
        public bool Exit;
        public WindowManager WindowManager;
        public WindowsGraphics WindowsGraphics;

        public GraphicsManager()
        {
            this.Row = 0;
            this.Exit = false;
            this.WindowManager = WindowManager.Instance;
            this.WindowsGraphics = new WindowsGraphics();
        }


        public void DoOpeningOakSpeech(Trainer Player)
        {
            int counter = 0;
            string playerName = "";
            string rivalName = "";
            List<string> speech = WindowsGraphics.ProfOakSpeechIntro;
            while (!this.Exit)
            {
            if (counter < 3){RenderOakSpeech(counter, Player, WindowsGraphics.ProfOak, speech);}
            if (2 < counter & counter < 6){RenderOakSpeech(counter, Player, WindowsGraphics.TitlePokemon, speech);}
            if (5 < counter & counter < 8){RenderOakSpeech(counter, Player, WindowsGraphics.Me, speech);}
            if (7 < counter & counter < 11){RenderOakSpeech(counter, Player, WindowsGraphics.Rival, speech);}
            if (counter > 10){RenderOakSpeech(counter, Player, WindowsGraphics.Me, speech);}

            if (counter != 6 & counter != 9) {Console.ReadKey();}
            else if (counter == 6)
            {
                string? input = Console.ReadLine();
                if (input != "" && input != null){playerName = input;}
                else {playerName = "Ashe";}
                Player.SetName(playerName);

            }
            else if (counter == 9)
            {
                string? input = Console.ReadLine();
                if (input != "" && input != null){rivalName = input;}
                else {rivalName = "Red";}
                Player.SetRivalName(rivalName);
            }

            counter += 1;
            if (counter == WindowsGraphics.ProfOakSpeechIntro.Count){this.Exit = true;}
            }
            this.Exit = false;
        }

        public void RenderOakSpeech(int row, Trainer Player, List<string> visual, List<string> speech)
        {
            WindowManager.SetWindow(new OakSpeech());
            WindowManager.DisplayWindow(row, WindowsGraphics.CombineLists(visual, speech), Player, WindowsGraphics.EmptyOption);
        }

        public void DoOakPokemonSelect(Trainer Player)
        {
            int counter = 0;
            List<string> speech = WindowsGraphics.ProfOakSpeechPokemonChoosing;
            while (!this.Exit)
            {
                if (counter == 0){RenderOakSpeech(counter, Player, WindowsGraphics.Rival, speech);}
                if (counter > 0 && counter < 9){RenderOakSpeech(counter, Player, WindowsGraphics.ProfOak, speech);}
                if (counter == 9){RenderOakSpeech(counter, Player, WindowsGraphics.Rival, speech);}
                if (counter > 9){RenderOakSpeech(counter, Player, WindowsGraphics.ProfOak, speech);}
                Console.ReadKey();

                counter += 1;
                if (counter == WindowsGraphics.ProfOakSpeechPokemonChoosing.Count){this.Exit = true;}
            }
            this.Exit = false;
        }
    }
}