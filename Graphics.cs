using System;

namespace Pokemon
{
    public interface WindowDisplay
    {
        void DisplayWindow();
    }

    public class WindowManager
    {
        private WindowDisplay _window;

        public void SetWindow(WindowDisplay window)
        {
            _window = window;
        }
        public void DisplayWindow()
        {
            _window.DisplayWindow();
        }
    }

    public class Title : WindowDisplay
    {
        public void DisplayWindow()
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
        public void DisplayWindow()
        {
            Console.WriteLine("MainManu");
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. Credits");
            Console.WriteLine("3. Exit");
        }
    }
}

