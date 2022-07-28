using projeto_dio_CSharp_rpg.src.Entities;

namespace projeto_dio_CSharp_rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escolha a classe do seu personagem: (Knight, Ninja, White Wizard, Black Wizard)");
                var heroType = Console.ReadLine();
                string nome;
                int level;
                double hp;
                double mp;

                if (heroType == "Knight" || heroType == "White Wizard" || heroType == "Black Wizard")
                {
                    Console.WriteLine($"Você escolheu {heroType}");
                    Console.WriteLine("Digite os seus atributos: [Separados por vírgula] (Exemplo: Nome,Level,HP,MP)");
                    string[] dados = Console.ReadLine().Split(",");
                    nome = dados[0];
                    level = int.Parse(dados[1]);
                    hp = double.Parse(dados[2]);
                    mp = double.Parse(dados[3]);
                    Jogo.CriarPersonagem(nome, level, hp, mp, heroType);

                }
                else if (heroType == "Ninja")
                {
                    Console.WriteLine($"Você escolheu {heroType}");
                    Console.WriteLine("Digite os seus atributos: [Separados por vírgula] (Exemplo: Nome, Level, HP)");
                    string[] dados = Console.ReadLine().Split(",");
                    nome = dados[0];
                    level = int.Parse(dados[1]);
                    hp = double.Parse(dados[2]);
                    Jogo.CriarPersonagem(nome, level, hp, heroType);
                }
                else
                {
                    Console.WriteLine("Classe não existente");
                }
                
                Console.Write($"Dados do personagem criado: ");
                Jogo.VerDadosPersonagem();
                Jogo.PartidaBoss();
                Console.WriteLine("Jogo terminado, pressione enter para sair: ");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}