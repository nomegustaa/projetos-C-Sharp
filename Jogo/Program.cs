using System;

namespace Jogo{
    class Program{

        static string jogador1;
        static byte valorTiradoJogador1 = 0;

        static byte placarJ1 = 0;
        static string jogador2;
        static byte valorTiradoJogador2 = 0;

        static byte placarJ2 = 0;

        static byte rodadaAtual = 0;
        static int dados;

        static byte opcaoJogo;

        static byte reiniciar;

        static void Main(string[] args){
            Opcao();
        }

        static void Opcao()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("BEM-VINDO(A) AO JOGO DE DADOS");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Digite enter para entrar no jogo");
            Console.ReadKey();
            Jogadores();
        }


        // Cadastro dos jogadores
        static void Jogadores()
        {
            placarJ1 = 0;
            valorTiradoJogador1 = 0;
            valorTiradoJogador2 = 0;
            placarJ2 = 0;
            rodadaAtual = 0;
            Console.Clear();
            Console.WriteLine("Digite o nome do primeiro jogador: ");
            jogador1 = Console.ReadLine().ToUpper();
            if(String.IsNullOrEmpty(jogador1)){
                Console.WriteLine("O primeiro jogador não informou o nome dele");
                Console.WriteLine("Digite qualquer tecla para voltar ao inicio");
                Console.ReadKey();
                Jogadores();
            }else{  
                Console.WriteLine("Digite o nome do segundo jogador: ");
                jogador2 = Console.ReadLine().ToUpper();
                if(String.IsNullOrEmpty(jogador2)){
                    Console.WriteLine("O segundo jogador não informou o nome dele");
                    Console.WriteLine("Digite qualquer tecla para voltar ao inicio");
                    Console.ReadKey();
                    Jogadores();
                }else{
                    if(jogador1 == jogador2){
                    Console.WriteLine($"jogador {jogador1} e jogador {jogador2} tem nomes iguais, DIGITE NOVAMENTE");
                    Console.WriteLine("Digite qualquer tecla para voltar");
                    Console.ReadKey();
                    Jogadores();
                    }else{
                        InicioJogo();
                    }
                }
            }
        }

        static void InicioJogo()
        {
            Console.Clear();
            Console.WriteLine($"Olá {jogador1} e {jogador2}, bora jogar?");
            Console.WriteLine($"Digite ENTER para começar o jogo...");
            Console.ReadKey();
            Console.WriteLine("");
            while(rodadaAtual < 3){
                rodadaAtual++;
                Console.WriteLine("------------------------------");
                Console.WriteLine("");
                Console.WriteLine($"{jogador1} Digite ENTER para fazer sua jogada");
                Console.ReadKey();
                valorTiradoJogador1 = GerandoNumeros();
                Console.WriteLine($"O {jogador1} tirou o número {valorTiradoJogador1}");
                Console.WriteLine("");
                Console.WriteLine($"sua vez {jogador2}. Digite ENTER para fazer sua jogada");
                Console.ReadKey();
                valorTiradoJogador2 = GerandoNumeros();
                Console.WriteLine($"{jogador2} tirou o número {valorTiradoJogador2}");
                Console.WriteLine("");
                Console.WriteLine("------------------------------");
                Placar();
            }

            if(placarJ1 > placarJ2){
                Console.WriteLine("------------------------------");
                Console.WriteLine($"O VENCEDOR FOI {jogador1}");
                Console.WriteLine("------------------------------");
            }else if(placarJ2 > placarJ1){
                Console.WriteLine("------------------------------");
                Console.WriteLine($"O VENCEDOR FOI {jogador2}");
                Console.WriteLine("------------------------------");
            }
            Console.WriteLine("CHEGAMOS AO FIM DA RODADA...");
            ReiniciarJogo();
        }

        // Placar dos jogadores
        static void Placar()
        {
            if(valorTiradoJogador1 > valorTiradoJogador2){
                placarJ1++;
                Console.WriteLine($"{jogador1} ganhou a rodada de número {rodadaAtual}");
                Console.WriteLine("------------------------------");
                

            }else if(valorTiradoJogador2 > valorTiradoJogador1){
                placarJ2++;
                Console.WriteLine($"{jogador2} ganhou a rodada de número {rodadaAtual}");
                Console.WriteLine("------------------------------");
                

            }else if(valorTiradoJogador1 == valorTiradoJogador2){
                Console.WriteLine($"O {jogador1} e {jogador2} tiraram o mesmo número");
                Console.WriteLine($"Portanto, resultado EMPATE");
                Console.WriteLine("------------------------------");
            }
                Console.WriteLine("");
                Console.WriteLine("---PLACAR---");
                Console.WriteLine($"{jogador1} = {placarJ1}");
                Console.WriteLine($"{jogador2} = {placarJ2}");
                Console.WriteLine($"rodada de número {rodadaAtual}");
                
        }


        // Número dos dados gerando de forma aleatória, usando Random.
        static byte GerandoNumeros()
        {
            Random numAleatorio = new Random();
            return Convert.ToByte(numAleatorio.Next(1,7));
        }

        static void ReiniciarJogo()
        {
            Console.WriteLine("");
            Console.WriteLine("Quer jogar novamente: ");
            Console.WriteLine("Digite [1] para jogar novamente e [2] para sair do jogo");
            reiniciar = byte.Parse(Console.ReadLine());
            switch(reiniciar){
                case 1: Jogadores();break;

                case 2: Environment.Exit(0);break;

                default: Console.WriteLine("DIGITE SOMENTE NÚMEROS [1] E [2]");ReiniciarJogo();break;
            }
        }

    }
}
