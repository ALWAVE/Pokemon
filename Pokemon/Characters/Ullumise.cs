using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Characters
{
    public class Ullumise : Pokemon
    {
        public Ullumise() 
        {
            Id = 0;
            Hp = 35;
            Name = "Illumise";
            Attack = "Overheat";
            Deffense = "BlockDamage";
            Speed = 1.05f;
            SpecialAttack = new SpecialAttack
            {
                Name = "Amnesia Splash",
                Power = 310
            };
            SpecialProtection = new SpecialProtection
            {
                Name = "BlockDamage",
                Protection = 50
            };

        }

    }
}
