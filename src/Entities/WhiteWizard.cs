using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_dio_CSharp_rpg.src.Entities
{
    public class WhiteWizard : Wizard
    {
        public WhiteWizard(string Name, int Level, double HP, double MP) : base ( Name,  Level, HP, MP)
        {
            HeroType = "White Wizard";
        }

        public override double Attack(double dano)
        {
            if(dano > HP * 0.5 && dano > MP)
            {
                return dano + (dano * 0.085);
            }
            else
            {
                return dano;
            }
        }
    }
}