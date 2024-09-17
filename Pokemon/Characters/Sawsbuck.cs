using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pokemon.Characters
{
    public class Sawsbuck : Pokemon
    {
        public Sawsbuck()
        {
            Id = 0;
            Hp = 25;
            Name = "Sawsbuck";
            Attack = "Facade";
            Deffense = "BlockDamage";
            Speed = 3.05f;
            SpecialAttack = new SpecialAttack
            {
                Name = "Quiver Dance",
                Power = 220
            };
            SpecialProtection = new SpecialProtection
            {
                Name = "HoofProtection",
                Protection = 5
            };
        }
    }
}
