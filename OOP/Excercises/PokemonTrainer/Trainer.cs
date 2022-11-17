using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    public class Trainer
    {

        public Trainer (string name)
        {
            pokemonCollection = new List<Pokemon>();
            Name = name;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set 
            { 
                name = value; 
            }
        }

        private int numberOfBadges;

        public int NumberOfBadges { get; set; }

        public List<Pokemon> pokemonCollection { get; set; }
    }
}
