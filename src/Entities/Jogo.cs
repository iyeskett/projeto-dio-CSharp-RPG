using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_dio_CSharp_rpg.src.Entities
{
    public static class Jogo
    {
        private static bool IsKnight;
        private static bool IsWWIzard;
        private static bool IsBWizard;
        private static bool IsNinja;
        private static Knight? knight;
        private static Ninja? ninja;
        private static WhiteWizard? whiteWizard;
        private static BlackWizard? blackWizard;

        private static Boss dioMaster = new Boss();

        private static string? heroType;


        public static void PartidaBoss()
        {
            while (dioMaster.HP > 0)
            {
                Console.WriteLine("Digite seu próximo ataque ao boss: ");
                var dano = double.Parse(Console.ReadLine());
                switch (heroType)
                {
                    case "Knight":
                        Atacar(knight, dioMaster, dano);
                        BossAtacar(dioMaster, knight, 250);
                        break;
                    case "White Wizard":
                        Atacar(whiteWizard, dioMaster, dano);
                        BossAtacar(dioMaster, whiteWizard, 250);
                        break;
                    case "Black Wizard":
                        Atacar(blackWizard, dioMaster, dano);
                        BossAtacar(dioMaster,blackWizard , 250);
                        break;
                    case "Ninja":
                        Atacar(ninja, dioMaster, dano);
                        BossAtacar(dioMaster, ninja, 250);
                        break;
                    default:
                        Console.WriteLine("Não foi possivel acertar o boss.");
                        break;
                }
                

            }
        }



        public static void CriarPersonagem(string Name, int Level, double HP, double MP, string HeroType)
        {
            switch (HeroType)
            {
                case "Knight":
                    knight = new Knight(Name, Level, HP, MP);
                    IsKnight = true;
                    heroType = HeroType;
                    break;
                case "White Wizard":
                    whiteWizard = new WhiteWizard(Name, Level, HP, MP);
                    IsWWIzard = true;
                    heroType = HeroType;
                    break;
                case "Black Wizard":
                    blackWizard = new BlackWizard(Name, Level, HP, MP);
                    IsBWizard = true;
                    heroType = HeroType;
                    break;
                default:
                    Console.WriteLine("Não foi possivel criar o personagem");
                    break;
            }
        }

        public static void CriarPersonagem(string Name, int Level, double HP, string HeroType)
        {

            ninja = new Ninja(Name, Level, HP);
            IsNinja = true;
            heroType = HeroType;

        }

        public static void VerDadosPersonagem()
        {
            switch (heroType)
            {
                case "Knight":
                    Console.WriteLine(knight);
                    break;
                case "White Wizard":
                    Console.WriteLine(whiteWizard);
                    break;
                case "Black Wizard":
                    Console.WriteLine(blackWizard);
                    break;
                case "Ninja":
                    Console.WriteLine(ninja);
                    break;
                default:
                    Console.WriteLine("Não foi possivel encontrar o personagem.");
                    break;
            }
        }



        public static void Atacar(Hero hero, Boss boss, double dano)
        {
            var danoAttack = hero.Attack(dano);
            boss.HP -= danoAttack;

            Console.WriteLine($"{hero.Name} atacou {boss.Name} e tirou {danoAttack} de HP");
        }

        public static void BossAtacar(Boss boss, Hero hero, double dano)
        {
            var danoAttack = hero.Attack(dano);
            hero.HP -= danoAttack;

            Console.WriteLine($"{boss.Name} atacou {hero.Name} e tirou {danoAttack} de HP");
        }

        public static void Curar(Hero hero)
        {
            if (hero.Level > 10)
            {
                hero.HP += 50;
            }
            else
            {
                hero.HP += 25;
            }
        }

    }
}