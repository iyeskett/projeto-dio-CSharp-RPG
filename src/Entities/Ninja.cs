using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_dio_CSharp_rpg.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, double HP) : base(name, level, HP)
        {
            HeroType = "Ninja";
        }

        public override double Attack(double dano)
        {
            if(Level > 20)
            {
                return dano + (dano * 0.10);
            }
            else
            {
                return dano;
            }
        }
    }
}