namespace Poke
{
    public interface IWindowDisplay
    {
        void DisplayWindow(int row, List<string> strings, Trainer trainer);
    }

    public class Middler
    {
        public void Print(string row, int width)
        {
            Console.WriteLine(new string(' ', width/2 - (row.Length/2)) + row);
        }
        
        public void PrintGameWindow(int x, int y, string backgroundRow, string playerRow, int playerCoord)
        {
            int width = Console.WindowWidth;
            string start = backgroundRow.Substring(0, playerCoord);
            string end = backgroundRow.Substring(playerCoord + start.Length);
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
}