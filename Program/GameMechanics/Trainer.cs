namespace Poke
{
    public class Trainer
    {
        public string? Name;
        public List<IPokemon>? Pokemons;
        public Dictionary<string, int>? Inventory;
        public string? RivalName;
        public IPokemon? RivalPokemon;
        public string Location;
        
        public Trainer()
        {
            this.Name = null;
            this.Pokemons = new List<IPokemon>();
            this.Inventory = new Dictionary<string, int>();
            this.RivalName = null;
            this.Location = "menu";
        }

        public void SetName(string? name)
        {
            this.Name = name;
        }

        public void SetRivalName(string name)
        {
            this.RivalName = name;
        }
    }
}