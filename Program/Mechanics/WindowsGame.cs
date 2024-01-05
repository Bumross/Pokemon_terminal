using System.Linq;

namespace Poke
{
    public class OakSpeech : IWindowDisplay
    {
        Formater Formater = Formater.Instance;

        public void DisplayWindow(int row, List<string> strings, Trainer trainer, List<string> optionText)
        {
            Console.Clear();
            List<string> oakVisual = Formater.Separate(strings)[0];
            List<string> oakSpeech = Formater.Separate(strings)[1];
            
            for (int i = 0; i < 5; i++){Console.WriteLine("");}
            foreach (string oakrow in oakVisual)
            {
                Formater.Print(oakrow, Console.WindowWidth);
            }
            for (int i = 0; i < 3; i++){Console.WriteLine("");}
            Formater.Print(oakSpeech[row].Replace("PLAYER_NAME", trainer.Name).Replace("RIVAL_NAME", trainer.RivalName), Console.WindowWidth);
            for (int i = 0; i < (Console.WindowHeight - oakVisual.Count - 9); i++){Console.WriteLine("");}

            if (trainer.Name == null & trainer.RivalName == null)
            {
                if (oakSpeech[row+1].Contains("PLAYER_NAME"))
                {
                    if (trainer.Name == null)
                    {
                        Console.WriteLine("Enter your name: ");
                    }
                    else
                    {
                        Formater.Print("Press Enter to continue", Console.WindowWidth);
                    }
                }
                else if (oakSpeech[row+1].Contains("RIVAL_NAME"))
                {
                    if (trainer.RivalName == null)
                    {
                        Console.WriteLine("Enter your name: ");
                    }
                    else
                    {
                        Formater.Print("Press Enter to continue", Console.WindowWidth);
                    }
                }
            }
            else
            {
            Formater.Print("Press Enter to continue", Console.WindowWidth);
            }
        }
    }

    public class Room : IWindowDisplay
    {
        Formater Formater = Formater.Instance;
        public void DisplayWindow(int row, List<string> strings, Trainer trainer, List<string> optionText)
        {
            Console.Clear();
            List<string> room = Formater.Separate(strings)[0];
            List<string> me = Formater.Separate(strings)[1];

            List<int> coordsMe = Formater.MoveToTheMiddle(me);
            int k = 0;
            foreach ((string listrow, int index) in room.Select((listrow, index) => (listrow, index)))
            {
                if (index <= coordsMe[1] & index > coordsMe[2])
                {
                    Formater.PrintGameWindow(0, 0, listrow, me[k], coordsMe[0]);
                    k += 1;
                }
                else
                {
                    Formater.Print(listrow, Console.WindowWidth);
                }
            }
            Formater.PrintOptions(row, optionText);
        }
    }
}