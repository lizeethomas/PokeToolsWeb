namespace PokéToolsWeb.Models
{
    public class Pokemon
    {
        public int Dex { get; set; }
        public string Name { get; set; }
        public string Form { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public int Total { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpAtk { get; set; }
        public int SpDef { get; set; }
        public int Speed { get; set; }
        public int Gen { get; set; }

        public string? Nom { get; set; }
        public int? Ether { get; set; }
        public int? Psycox { get; set; }

        public string IconUrl { get; set; }

        public Tiers Tiers { get; set; }
    }
}
