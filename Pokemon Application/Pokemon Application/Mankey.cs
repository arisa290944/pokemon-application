using Pokemon_Application.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Application
{
    internal class Mankey : Pokemon
    {
        public Mankey()
        {
            base.name = "Mankey";
            base.height = 1.08;
            base.weight = 61.7;
            base.gender = new List<Gender> { Gender.Male, Gender.Female };
            base.category = new List<Category> { Category.Pig_Monkey };
            base.abilities = new List<Abilities> { Abilities.Vital_Spirit, Abilities.Anger_Point };
            base.type = new List<PokemonType> { PokemonType.Fighting };
            base.imagename = Resources.mankey_1;
        }
    }
}
