using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_dio_CSharp_rpg.src.Entities
{
    public class BlackWizard : Wizard
    {
        public BlackWizard(string Name, int Level, double HP, double MP) : base ( Name,  Level, HP, MP)
        {
            HeroType = "Black Wizard";
        }

        public override double Attack(double dano)
        {
            if(dano > HP * 0.5 && dano > MP * 0.9)
            {
                return dano + (dano * 0.09);
            }
            else
            {
                return dano;
            }
        }
        
    }
}