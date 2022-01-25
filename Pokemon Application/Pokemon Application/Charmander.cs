using Pokemon_Application.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Application
{
    internal class Charmander : Pokemon
    {
        public Charmander()
        {
            base.name = "Charmander";
            base.height = 2;
            base.weight = 18.7;
            base.gender = new List<Gender> { Gender.Male, Gender.Female };
            base.category = new List<Category> { Category.Lizard };
            base.abilities = new List<Abilities> { Abilities.Blaze };
            base.type = new List<PokemonType> { PokemonType.Fire };
            base.imagename = Resources.charmander_1;
        }
    }
}
