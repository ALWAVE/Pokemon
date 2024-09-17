using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pokemon.Characters
{
    public class Deerling : Pokemon
    {
        public Deerling()
        {
            Id = 1;
            Hp = 25;
            Name = "Deerling";
            Attack = "Facade";
            Deffense = "BlockDamage";
            Speed = 1.85f;
            SpecialAttack = new SpecialAttack
            {
                Name = "Swagger",
                Power = 55
            };
            SpecialProtection = new SpecialProtection
            {
                Name = "ParryDamage",
                Protection = 33
            };
        }
    }
}
