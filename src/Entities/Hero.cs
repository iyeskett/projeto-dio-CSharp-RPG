using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_dio_CSharp_rpg.src.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public double HP { get; set; }
        public string HeroType { get; set; }

        public Hero(string name, int level, double HP)
        {
            Name = name;
            Level = level;
            this.HP = HP;
            HeroType = string.Empty;
        }

        public virtual double Attack(double dano)
        {
            return dano;
        }

        public override string ToString()
        {
            return $"{Name} {Level} {HeroType}";
        }
    }
}