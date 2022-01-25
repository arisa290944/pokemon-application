using Pokemon_Application.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Application
{
    internal class Paras : Pokemon
    {
        public Paras()
        {
            base.name = "Paras";
            base.height = 1;
            base.weight = 11.9;
            base.gender = new List<Gender> { Gender.Male, Gender.Female };
            base.category = new List<Category> { Category.Mushroom };
            base.abilities = new List<Abilities> { Abilities.Effect_Spore, Abilities.Dry_Skin };
            base.type = new List<PokemonType> { PokemonType.Bug, PokemonType.Grass };
            base.imagename = Resources.paras_1;
        }
    }
}
