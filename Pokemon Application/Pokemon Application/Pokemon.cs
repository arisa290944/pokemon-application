using Pokemon_Application.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Application
{
    internal class Pokemon
    {
        protected string name;
        protected double height;
        protected double weight;
        protected List<Gender> gender;
        protected List<Category> category;
        protected List<Abilities> abilities;
        protected List<PokemonType> type;
        protected Bitmap imagename;

        public string getName()
        {
            return name;
        }
        public Bitmap getImage(){
            return imagename;
        }
    }
    enum Gender {
        Male, Female
    }
    enum Category {
        Lizard,
        Mouse,
        Ballon,
        Mushroom,
        Fairy,
        Pig_Monkey
    }
    enum PokemonType {
        Fire,
        Ground,
        Normal,
        Fairy,
        Bug,
        Grass,
        Fighting
    }
    enum Abilities {
        Blaze,
        Sand_Veil,
        Cute_Charm,
        Competitive,
        Effect_Spore,
        Dry_Skin,
        Magic_Guard,
        Vital_Spirit,
        Anger_Point
    }
}