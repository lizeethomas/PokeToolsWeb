﻿namespace PokéToolsWeb.Models
{
    public class Ability
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? PokeApiIdentifier { get; set; }
        public bool IsHidden { get; set; }
    }
}
