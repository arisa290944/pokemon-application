using Pokemon_Application.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Application
{
    internal class Jigglypuff : Pokemon
    {
        public Jigglypuff()
        {
            base.name = "Jigglypuff";
            base.height = 1.08;
            base.weight = 12.1;
            base.gender = new List<Gender> { Gender.Male, Gender.Female };
            base.category = new List<Category> { Category.Ballon };
            base.abilities = new List<Abilities> { Abilities.Cute_Charm, Abilities.Competitive };
            base.type = new List<PokemonType> { PokemonType.Normal, PokemonType.Fairy };
            base.imagename = Resources.jigglypuff_1;
        }
    }
}
