using System;

namespace Pokemon
{


    public class WindowManager
    {
        private WindowDisplay _window;

        public void SetWindow(WindowDisplay window)
        {
            _window = window;
        }
        public void DisplayWindow(int row)
        {
            _window.DisplayWindow(row);
        }
    }

    public class Title : WindowDisplay
    {
        public void DisplayWindow(int row)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                           @");
            Console.WriteLine("                                         @");
            Console.WriteLine("           #@@@@@@@@@       @@@@  @@@    @@@@    @@@ @@@       @&");
            Console.WriteLine("          @@@@@@@  @@@       @@@@@@@  @@   @@   /@@@@@@@        @@@  @@@");
            Console.WriteLine("             @@@@   @@  @ @@@ @@@@    @@@@@.@@@  @@@@@@@ @  @@@@ @@@ @@@");
            Console.WriteLine("              @@@@@@  @@@   @@ @@ @@@@  *@@@    @@@ @ @ @@@@@@@@ @@@@@@");
            Console.WriteLine("               @@@@   @@@@@@@ @@@      @@@            @@  @@@  @@ @@@@");
            Console.WriteLine("                @@@&                                              @@@");
            Console.WriteLine("                 @");
            Console.WriteLine("");
            Console.WriteLine("                                   Battle Replica");
            Console.WriteLine("                              Press any key to start...");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                              By Alex Schönfelder, 2023");
        }
    }

    public class MainManu : WindowDisplay
    {
        public void DisplayWindow(int row)
        {
            Console.Clear();
            Console.WriteLine("Main Menu");

            Func<int, string> getMenuOption = (index) =>
            {
                switch (index)
                {
                    case 0: return "Start Game";
                    case 1: return "Credits";
                    case 2: return "Exit";
                    default: return "Unknown Option";
                }
            };

            for (int i = 0; i < 3; i++)
            {
                string arrow = (i == row) ? ">>" : "  ";
                Console.WriteLine($"{arrow} {getMenuOption(i)}");
            }
        }
    }
}

