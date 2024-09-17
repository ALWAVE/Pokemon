using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public abstract class Pokemon
    {
      public int Id { get; set; }
      public int Hp { get; set; }
      public string ?Name { get; set; }
      public string ?Attack {  get; set; }
      public string? Deffense { get; set; }
      public float ?Speed { get; set; }

      public SpecialAttack ?SpecialAttack { get; set; }
      public SpecialAttack? SpecialAttackUpgrade { get; set; }
      public SpecialProtection ?SpecialProtection { get; set; }
    }
}
