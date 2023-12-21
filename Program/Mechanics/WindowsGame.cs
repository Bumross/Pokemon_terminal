namespace Poke
{
    public class OakSpeech : IWindowDisplay
    {
        Middler middler = new Middler();

        public void DisplayWindow(int row, List<string> strings)
        {
            Console.Clear();
            int separatorIndex = strings.IndexOf("NEXT_LIST");
            List<string> oakVisual = strings.GetRange(0, separatorIndex);
            List<string> oakSpeech = strings.GetRange(separatorIndex + 1, strings.Count - separatorIndex - 1);
            
            for (int i = 0; i < 5; i++){Console.WriteLine("");}
            foreach (string oakrow in oakVisual)
            {
                middler.Print(oakrow, Console.WindowWidth);
            }
            for (int i = 0; i < 3; i++){Console.WriteLine("");}
            middler.Print(oakSpeech[row], Console.WindowWidth);
            for (int i = 0; i < (Console.WindowHeight - oakVisual.Count - 9); i++){Console.WriteLine("");}
            if (oakSpeech[row+1].Contains("PLAYER_NAME"))
            {
                Console.WriteLine("Enter your name: ");
            }
            else if (oakSpeech[row+1].Contains("RIVAL_NAME"))
            {
                Console.WriteLine("Enter the name of the enemy: ");
            }
            else
            {
            middler.Print("Press Enter to continue", Console.WindowWidth);
            }
        }
    }
}