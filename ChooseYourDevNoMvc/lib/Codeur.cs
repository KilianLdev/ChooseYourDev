using System;
using System.Collections.Generic;

namespace lib {
    public class Codeur : Personne {
        private string pokemonName;
        private float rating;
        private string description;
        private Languages language;
        private float price;
        private List<string> comments = new List<string>();

        public string PokemonName { get; set; }
        public float Rating { get; set; }
        public string Description { get; set; }
        public string Languages { get; set; }
        public float Price { get; set; }
        public List<string> Comments { 
            get {
                return this.comments;
            }
            set {
                this.comments = value;
            }    
        }
    }
}
