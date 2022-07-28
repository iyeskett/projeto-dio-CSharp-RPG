using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_dio_CSharp_rpg.src.Entities
{
    public class Knight : Hero
    {
        public double MP { get; set; }
        public Knight (string Name, int Level, double HP, double MP) : base (Name, Level, HP)
        {
            this.HP = HP;
            this.MP = MP;
            HeroType = "Knight";
        }

        public override double Attack(double dano)
        {
            if (dano > HP * 0.5 || dano < MP)
            {
                return dano  + (dano * 0.06);
            }
            else
            {
                return dano;
            }
        }
        
    }
}