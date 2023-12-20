using System;

namespace Pokemon
{


    public class WindowManager
    {
        private WindowDisplay? _window;

        public void SetWindow(WindowDisplay window)
        {
            _window = window;
        }
        public void DisplayWindow(int row)
        {
            _window?.DisplayWindow(row);
        }
    }


// Main Logo POKEMON (If you dont notice)
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

// Main Manu display
    public class MainManu : WindowDisplay
    {
        public void DisplayWindow(int row)
        {
            Console.Clear();
            for (int i = 0; i < 3; i++){Console.WriteLine("");}
            Console.WriteLine("                                            Main Menu");
            for (int i = 0; i < 2; i++){Console.WriteLine("");}

            Func<int, string> getMenuOption = (index) =>
            {
                switch (index)
                {
                    case 0: return "                                       Start Game";
                    case 1: return "                                        Credits";
                    case 2: return "                                          Exit";
                    default: return "Unknown Option";
                }
            };

            for (int i = 0; i < 3; i++)
            {
                string optionText = getMenuOption(i);
                int firstNonSpaceIndex = optionText.IndexOf(optionText.TrimStart()[0]);
                string arrow = (i == row) ? ">>" : "  ";
                string arrow2 = (i == row) ? "<<" : "  ";
                Console.WriteLine($"{optionText.Substring(0, firstNonSpaceIndex)}{arrow}  {optionText.Substring(firstNonSpaceIndex)}  {arrow2}");
            }
        }
    }

// Credits info ()
    public class Credits : WindowDisplay
    {
        public void DisplayWindow(int row)
        {
            Console.Clear();
            for (int i = 0; i < 3; i++){Console.WriteLine("");}
            Console.WriteLine("                                            Credits");
            for (int i = 0; i < 2; i++){Console.WriteLine("");}
            Console.WriteLine("                           This project was created as part of a seminar");
            Console.WriteLine("                           focusing on object-oriented design patterns.");
            Console.WriteLine();
            Console.WriteLine("                            Thank you for your time spent downloading");
            Console.WriteLine("                                   and running this project.");
            Console.WriteLine();
            Console.WriteLine("                           I hope you enjoy the experience of this game!");
            Console.WriteLine("                                        Happy exploring!");

        }
    }
}

