using System;

namespace Poke
{
    public class WindowManager
    {
        private IWindowDisplay? _window;

        public void SetWindow(IWindowDisplay window)
        {
            _window = window;
        }
        public void DisplayWindow(int row, List<string> strings, Trainer trainer, List<string> optionText)
        {
            _window?.DisplayWindow(row, strings, trainer, optionText);
        }
    }


// Main Logo POKEMON (If you dont notice)
    public class Title : IWindowDisplay
    {
        Middler middler = new Middler();
        public void DisplayWindow(int row, List<string> strings, Trainer trainer, List<string> optionText)
        {
            int Width = Console.WindowWidth;
            int Height = Console.WindowHeight;
            int Top = Height/3;
            int Fill = Height - Top - 13;
            int Middle = Width/2;
            Console.Clear();
            for (int i = 0; i < Top; i++){Console.WriteLine("");}
            foreach (string logo_row in strings)
            {
                middler.Print(logo_row, Width);
            }
            Console.WriteLine("");
            Console.WriteLine(new string(' ', Middle - ("Terminal Replica").Length / 2) + ("Terminal Replica"));
            Console.WriteLine(new string(' ', Middle - ("Press any key to start...").Length / 2) + ("Press any key to start..."));
            for (int i = 0; i < Fill; i++){Console.WriteLine("");}
            Console.WriteLine(new string(' ', Middle - ("By Alex Schönfelder, 2023").Length / 2) + ("By Alex Schönfelder, 2023"));
        }
    }


// Main Manu display
    public class MainManu : IWindowDisplay
    {
        Middler middler = new Middler();
        public void DisplayWindow(int row, List<string> strings, Trainer trainer, List<string> optionText)
        {
            Console.Clear();
            for (int i = 0; i < Console.WindowHeight/3; i++){Console.WriteLine("");}
            middler.Print("Main Menu ", Console.WindowWidth);
            for (int i = 0; i < 2; i++){Console.WriteLine("");}

            middler.PrintOptions(row, strings);
            for (int i = 0; i < 10; i++){Console.WriteLine("");}
            middler.Print("Arrows to move, Enter to select", Console.WindowWidth);
        }
    }


// Credits info ()
    public class Credits : IWindowDisplay
    {
        Middler middler = new Middler();
        public void DisplayWindow(int row, List<string> strings, Trainer trainer, List<string> optionText)
        {
            Console.Clear();
            for (int i = 0; i < Console.WindowHeight/3; i++){Console.WriteLine("");}
            foreach (string cred_row in strings)
            {
                middler.Print(cred_row, Console.WindowWidth);
            }
        }
    }


    public class Exit : IWindowDisplay
    {
        Middler middler = new Middler();
        public void DisplayWindow(int row, List<string> strings, Trainer trainer, List<string> optionText)
        {
            Console.Clear();
            for (int i = 0; i < Console.WindowHeight/3; i++){Console.WriteLine("");}
            foreach (string logrow in strings)
            {
                middler.Print(logrow, Console.WindowWidth);
            }
            Console.WriteLine("");
            middler.Print("Thank you for playing!", Console.WindowWidth);
        }
    }
}