using Pokemon_Application.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Application
{
    internal class Sandshrew : Pokemon
    {
        public Sandshrew()
        {
            base.name = "Sandshrew";
            base.height = 2;
            base.weight = 26.5;
            base.gender = new List<Gender> { Gender.Male, Gender.Female };
            base.category = new List<Category> { Category.Mouse };
            base.abilities = new List<Abilities> { Abilities.Sand_Veil };
            base.type = new List<PokemonType> { PokemonType.Ground };
            base.imagename = Resources.sandshrew_1;
        }
    }
}
