using System.Xml.XPath;

namespace Poke
{
    public class PokemonFactory
    {
        public IPokemon CreatePokemon(int pokemonID)
        {
            switch (pokemonID)
            {
                case 1:
                    return new Bulbasaur();
                case 4:
                    return new Squirtle();
                case 7:
                    return new Charmander();
                default:
                    return new Charmander();
            }
        }
    }


    public abstract class Pokemon : IPokemon
    {
        protected int Xp;
        protected int Id;
        protected int Hp;
        protected int Lvl;
        protected bool IsCaptured;
        public Pokemon(int xp, int id)
        {
            this.Xp = xp;
            this.Id = id;
            this.Lvl = 0;
            this.IsCaptured = false;
        }
        public int GetId()
        {
            return this.Id;
        }
        public void Attack(IPokemon enemy)
        {
            enemy.GainDamage(10);
        }
        public void Capture()
        {
            this.IsCaptured = true;
        }
        public void GainDamage(int damage)
        {
            this.Hp -= damage;
        }
        public void GainXP(int xp)
        {
            this.Xp += xp;
        }
        public void Heal(int heal)
        {
            this.Hp += heal;
        }
        public void LevelUp()
        {
            this.Lvl += 1;
        }
        public abstract List<string> ShowAttacks();
        public List<string> ShowStats()
        {
            return new List<string>() {"ID: " + this.Id, "XP: " + this.Xp, "HP: " + this.Hp, "LVL: " + this.Lvl};
        }
    }


    public class Charmander : Pokemon
    {
        Dictionary<string, int> Attacks = new Dictionary<string, int>();
        public Charmander() : base(65, 4) {}

        public override List<string> ShowAttacks()
        {
            throw new NotImplementedException();
        }
    }

    public class Bulbasaur : Pokemon
    {
        Dictionary<string, int> Attacks = new Dictionary<string, int>();
        public Bulbasaur() : base(64, 1) {}

        public override List<string> ShowAttacks()
        {
            throw new NotImplementedException();
        }
    }


    public class Squirtle : Pokemon
    {
        Dictionary<string, int> Attacks = new Dictionary<string, int>();
        public Squirtle() : base(66, 7) {}

        public override List<string> ShowAttacks()
        {
            throw new NotImplementedException();
        }

    }
}