using Pokemon_Application.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Application
{
    internal class Clefairy : Pokemon
    {
        public Clefairy()
        {
            base.name = "Clefairy";
            base.height = 2;
            base.weight = 16.5;
            base.gender = new List<Gender> { Gender.Male, Gender.Female };
            base.category = new List<Category> { Category.Fairy };
            base.abilities = new List<Abilities> { Abilities.Cute_Charm, Abilities.Magic_Guard };
            base.type = new List<PokemonType> { PokemonType.Fairy };
            base.imagename = Resources.clefairy_1;
        }
    }
}
