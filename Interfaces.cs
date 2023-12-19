namespace Pokemon
{
    public interface WindowDisplay
    {
        void DisplayWindow(int row);
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