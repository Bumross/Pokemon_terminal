namespace Pokemon
{
    public interface IWindowDisplay
    {
        void DisplayWindow(int row, List<string> strings);
    }


    interface IPokemon
    {
        void Attack(){}
        void ShowStats(){}
        void LevelUp(){}
        void ShowAttacks(){}
    }

    interface Type
    {

    }
}