using System;

namespace RPGteste
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introdução ao jogo
            Console.WriteLine("Bem-vindo ao RPG de Texto!");
            Console.WriteLine("Qual é o seu nome, aventureiro?");
            
            string playerName = Console.ReadLine(); 
            Console.WriteLine($"Saudações, {playerName}! Sua jornada começa agora...");

          
            IniciarJogo(playerName);
        }

        static void IniciarJogo(string nomeJogador)
        {
            Console.WriteLine($"{nomeJogador}, você se encontra em uma encruzilhada.");
            Console.WriteLine("Você pode seguir para o norte, sul, leste ou oeste. Qual caminho você escolhe?");
            Console.WriteLine("1. Norte");
            Console.WriteLine("2. Sul");
            Console.WriteLine("3. Leste");
            Console.WriteLine("4. Oeste");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Console.WriteLine("Você seguiu para o norte e encontrou uma floresta sombria.");
                    Floresta(nomeJogador);
                    break;
                case "2":
                    Console.WriteLine("Você seguiu para o sul e encontrou uma vila pacífica.");
                    Vila(nomeJogador);
                    break;
                case "3":
                    Console.WriteLine("Você seguiu para o leste e encontrou uma montanha alta.");
                    Montanha(nomeJogador);
                    break;
                case "4":
                    Console.WriteLine("Você seguiu para o oeste e encontrou um rio caudaloso.");
                    Rio(nomeJogador);
                    break;
                default:
                    Console.WriteLine("Escolha inválida. Tente novamente.");
                    IniciarJogo(nomeJogador);
                    break;
            }
        }

        static void Floresta(string nomeJogador)
        {
            Console.WriteLine($"{nomeJogador}, você está na floresta. Um lobo selvagem aparece!");
            Console.WriteLine("O que você faz?");
            Console.WriteLine("1. Atacar");
            Console.WriteLine("2. Fugir");

            string acao = Console.ReadLine();

            if (acao == "1")
            {
                Console.WriteLine("Você ataca o lobo e o derrota!");
                // Adicionar lógica de combate aqui
            }
            else if (acao == "2")
            {
                Console.WriteLine("Você foge da floresta com segurança.");
                IniciarJogo(nomeJogador);
            }
            else
            {
                Console.WriteLine("Escolha inválida. Tente novamente.");
                Floresta(nomeJogador);
            }
        }

        static void Vila(string nomeJogador)
        {
            Console.WriteLine($"{nomeJogador}, você chega à vila e encontra um mercador.");
            Console.WriteLine("Ele oferece uma poção por 10 moedas de ouro. Deseja comprar?");
            Console.WriteLine("1. Sim");
            Console.WriteLine("2. Não");

            string escolha = Console.ReadLine();

            if (escolha == "1")
            {
                Console.WriteLine("Você compra a poção e a guarda no seu inventário.");
                // Adicionar lógica de inventário aqui
            }
            else
            {
                Console.WriteLine("Você decide não comprar e continua sua jornada.");
                IniciarJogo(nomeJogador);
            }
        }

        static void Montanha(string nomeJogador)
        {
            Console.WriteLine($"{nomeJogador}, você chega à montanha e vê uma caverna misteriosa.");
            Console.WriteLine("Você quer explorar a caverna?");
            Console.WriteLine("1. Sim");
            Console.WriteLine("2. Não");

            string escolha = Console.ReadLine();

            if (escolha == "1")
            {
                Console.WriteLine("Você entra na caverna e encontra um tesouro!");
                // Adicionar lógica de exploração
            }
            else
            {
                Console.WriteLine("Você decide não explorar e retorna à encruzilhada.");
                IniciarJogo(nomeJogador);
            }
        }
        

        static void Rio(string nomeJogador)
        {
            Console.WriteLine($"{nomeJogador}, você chega ao rio e vê uma ponte.");
            Console.WriteLine("Você quer atravessar a ponte?");
            Console.WriteLine("1. Sim");
            Console.WriteLine("2. Não");

            string escolha = Console.ReadLine();

            if (escolha == "1")
            {
                Console.WriteLine("Você atravessa a ponte com sucesso.");
                // Adicionar lógica para novas áreas
            }
            else
            {
                Console.WriteLine("Você decide não atravessar e volta para a encruzilhada.");
                IniciarJogo(nomeJogador);
            }
            
        }
   
  static void Combate(string nomeJogador, int vidaInimigo)
{
    int vidaJogador = 100;

    Console.WriteLine($"Um inimigo aparece com {vidaInimigo} de vida!");

    while (vidaJogador > 0 && vidaInimigo > 0)
    {
        Console.WriteLine("O que você deseja fazer?");
        Console.WriteLine("1. Atacar");
        Console.WriteLine("2. Fugir");

        string acao = Console.ReadLine();

        if (acao == "1")
        {
            Random random = new Random();
            int danoJogador = random.Next(5, 15);
            int danoInimigo = random.Next(5, 15);

            vidaInimigo -= danoJogador;
            vidaJogador -= danoInimigo;

            Console.WriteLine($"Você causou {danoJogador} de dano ao inimigo.");
            Console.WriteLine($"O inimigo causou {danoInimigo} de dano a você.");
            Console.WriteLine($"Sua vida: {vidaJogador} | Vida do inimigo: {vidaInimigo}");
        }
        else if (acao == "2")
        {
            Console.WriteLine("Você fugiu do combate.");
            IniciarJogo(nomeJogador);
            return;
        }

        if (vidaInimigo <= 0)
        {
            Console.WriteLine("Você derrotou o inimigo!");
        }
        else if (vidaJogador <= 0)
        {
            Console.WriteLine("Você foi derrotado.");
        }
    }
}
 }
}


