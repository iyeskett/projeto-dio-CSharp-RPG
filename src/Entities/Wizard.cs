using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_dio_CSharp_rpg.src.Entities
{
    public class Wizard : Hero
    {
        public double MP { get; set; }

        public Wizard(string Name, int Level, double HP, double MP) : base ( Name,  Level, HP)
        {
            this.HP = HP;
            this.MP = MP;
            HeroType = "Wizard";
        }

        public override double Attack(double dano)
        {
            if (dano > MP )
            {
                return dano * 0.10;
            }
            else
            {
                return dano;
            }
            
        }

    }
}