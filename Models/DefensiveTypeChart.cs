namespace PokéToolsWeb.Models
{
    public class DefensiveTypeChart
    {
        public string Pokemon { get; set; }
        public string[] Types { get; set; }
        public Dictionary<string, double> Weaknesses { get; set; }
        public Dictionary<string, double> Resistances { get; set; }
        public Dictionary<string, double> Immunities { get; set; }
    }
}
