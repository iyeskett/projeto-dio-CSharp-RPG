using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_dio_CSharp_rpg.src.Entities
{
    public class Boss 
    {
         public string Name { get; set; }
        public int Level { get; set; }
        public double HP { get; set; }

        public Boss()
        {
            Name = "Dio Master Matador de Bugs";
            Level = 2000;
            HP = 2500;
        }
    }
}