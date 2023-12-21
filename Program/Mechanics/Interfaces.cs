namespace Poke
{
    public interface IWindowDisplay
    {
        void DisplayWindow(int row, List<string> strings);
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