using System;

namespace Poke
{
// Main Logo POKEMON (If you dont notice)
    public class Title : IWindowDisplay
    {
        Formater Formater = Formater.Instance;
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
                Formater.Print(logo_row, Width);
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
        Formater Formater = Formater.Instance;
        public void DisplayWindow(int row, List<string> strings, Trainer trainer, List<string> optionText)
        {
            Console.Clear();
            for (int i = 0; i < Console.WindowHeight/3; i++){Console.WriteLine("");}
            Formater.Print("Main Menu ", Console.WindowWidth);
            for (int i = 0; i < 2; i++){Console.WriteLine("");}

            Formater.PrintOptions(row, strings);
            for (int i = 0; i < 10; i++){Console.WriteLine("");}
            Formater.Print("Arrows to move, Enter to select", Console.WindowWidth);
        }
    }


// Credits info ()
    public class Credits : IWindowDisplay
    {
        Formater Formater = Formater.Instance;
        public void DisplayWindow(int row, List<string> strings, Trainer trainer, List<string> optionText)
        {
            Console.Clear();
            for (int i = 0; i < Console.WindowHeight/3; i++){Console.WriteLine("");}
            foreach (string cred_row in strings)
            {
                Formater.Print(cred_row, Console.WindowWidth);
            }
        }
    }


    public class Exit : IWindowDisplay
    {
        Formater Formater = Formater.Instance;
        public void DisplayWindow(int row, List<string> strings, Trainer trainer, List<string> optionText)
        {
            Console.Clear();
            for (int i = 0; i < Console.WindowHeight/3; i++){Console.WriteLine("");}
            foreach (string logrow in strings)
            {
                Formater.Print(logrow, Console.WindowWidth);
            }
            Console.WriteLine("");
            Formater.Print("Thank you for playing!", Console.WindowWidth);
        }
    }
}