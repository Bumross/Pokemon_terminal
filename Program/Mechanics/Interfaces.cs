namespace Poke
{
    public interface IWindowDisplay
    {
        void DisplayWindow(int row, List<string> strings, Trainer trainer, List<string> optionText);
    }

    public class Middler //Singleton
    {
        private static Middler? instance;
        private Middler(){}
        public static Middler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Middler();
                }
                return instance;
            }

        }
        public void Print(string row, int width)
        {
            Console.WriteLine(new string(' ', width/2 - (row.Length/2)) + row);
        }
        
        public void PrintGameWindow(int x, int y, string backgroundRow, string playerRow, int playerCoord)
        {
            int width = Console.WindowWidth;
            int startGap = width/2 - (backgroundRow.Length/2);
            string start = backgroundRow.Substring(0, playerCoord - startGap);
            string end = backgroundRow.Substring(start.Length);
            Console.Write(new string(' ', startGap));
            Console.Write(start);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(playerRow);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(end);
            Console.Write("\n");
        }

        public List<List<string>> Separate(List<string> list)
        {
            int separatorIndex = list.IndexOf("NEXT_LIST");
            if (separatorIndex == -1)
            {
                separatorIndex = list.Count - 1;
                return new List<List<string>>(){list, new List<string>(){" "}};
            }
            List<string> list1 = list.GetRange(0, separatorIndex);
            List<string> list2 = list.GetRange(separatorIndex + 1, list.Count - separatorIndex - 1);

            return new List<List<string>>(){list1, list2};
        }

        public List<int> MoveToTheMiddle(List<string> list)
        {
            int width = Console.WindowWidth;
            int height = Console.WindowHeight;
            List<int> lenLists = list.Select(str => str.Length).ToList();
            int listWidth = lenLists.Max();
            int listHeight = list.Count;

            int x = (width - listWidth) / 2;
            int y = (height + listHeight) / 2;
            int y2 = y - listHeight;
            return new List<int>(){x, y, y2};
        }

        public void PrintOptions(int row, List<string> strings)
        {
            for (int i = 0; i < strings.Count; i++)
            {
                string optionText = strings[i];
                string arrow = (i == row) ? ">>" : "  ";
                string arrow2 = (i == row) ? "<<" : "  ";
                this.Print($"{arrow}  {optionText}  {arrow2}", Console.WindowWidth);
            }
        }
    }

    public interface IPokemon
    {
        void Attack(IPokemon enemy);
        void ShowStats();
        void LevelUp();
        void GainXP(int xp);
        void ShowAttacks();
        void Heal(int heal);
        void GainDamage(int damage);
    }

    public interface IPokemonFactory
    {
        IPokemon CreatePokemon();
    }
}