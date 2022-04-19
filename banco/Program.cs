using System;

namespace Banco // Note: actual namespace depends on the project name.
{
    class Program
    {
        
        static float saldo = 150;
        static string nome;

        static string senhaNova;
        static string senhaAtual;
        static void Main(string[] args)
        {
            CriacaoUsuario();
        }

        static void CriacaoUsuario(){
            Console.Clear();
            Console.WriteLine("Digite seu nome :");
            nome = Console.ReadLine();
            Console.WriteLine("Crie uma senha para acesso: ");
            senhaNova = Console.ReadLine();
            Verificacao();
        }

        static void Verificacao(){
            Console.Clear();
            Console.WriteLine($"Olá {nome}, digite sua senha de acesso: ");
            senhaAtual = Console.ReadLine();
                if(senhaAtual == senhaNova){
                    Inicio();
                }else{
                    Console.WriteLine("Senha inváida - Tente novamente");
                    Console.WriteLine("Digite qualquer tecla para voltar");
                    Console.ReadKey();  
                    Verificacao();
                }
        }

        static void Senha(){
            Console.WriteLine("Digite sua senha de acesso: ");
            senhaAtual = Console.ReadLine();
            if(senhaAtual == senhaNova){
                Console.WriteLine("ACESSO PERMITIDO");
            }else{
                Console.WriteLine("Senha inváida - Tente novamente");
                Console.WriteLine("Digite qualquer tecla para voltar");
                Console.ReadKey();
                Inicio();
            }
        }
        static void erro_Defaul()
        {
            Console.WriteLine("Digite apenas um número de [1] a [5]");
            Console.WriteLine("Digite qualquer tecla para voltar para o inicio");
            Console.ReadKey();
            Inicio();
        }
        static void Inicio()
        {
            Console.Clear();
            Console.WriteLine($"Bem-vindo(a) {nome}");
            Console.WriteLine("");
            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("[1] - Saldo");
            Console.WriteLine("[2] - Saque");
            Console.WriteLine("[3] - Depósito");
            Console.WriteLine("[4] - Fazer transferência");
            Console.WriteLine("[5] - Sair");

            Console.WriteLine("======================");

            short escolha = short.Parse(Console.ReadLine());

            switch(escolha){
                case 1: VerSaldo(); break;

                case 2: Saque();break;

                case 3: Deposito(); break;

                case 4: Tranferencia();break;

                case 5: System.Environment.Exit(0); break;

                default: erro_Defaul(); break;
            }
        }
        
        static void VerSaldo()
        {
            Console.Clear();
            Senha();
            Console.WriteLine("--------SALDO---------");
            Console.WriteLine("");
            Console.WriteLine($"Seu saldo é de {saldo} reais");
            Console.WriteLine("Digite qualquer tecla para voltar para o inicio");
            Console.ReadKey();
            Inicio();
        }

        static void Saque(){
            Console.Clear();
            Senha();
            Console.WriteLine("--------SAQUE---------");
            Console.WriteLine("");
            Console.WriteLine("Digite o valor do seu saque: ");
            float saque = float.Parse(Console.ReadLine());
            if(saldo < saque){
                Console.WriteLine("Saldo Indisponível");
                Console.WriteLine("Digite qualquer tecla para voltar para o inicio");
                Console.ReadKey();
                Inicio();
            }else if(saque < 0){
                Console.WriteLine("Por favor, informa um número ou um número maior que 0");
                Console.WriteLine("Digite qualquer tecla para voltar para o inicio");
                Console.ReadKey();
                Inicio();
            }else{
                saldo = saldo - saque;
                Console.WriteLine("SAQUE EFETUADO COM SUCESSO");
                Console.WriteLine("Digite qualquer tecla para voltar para o inicio");
                Console.ReadKey();
                Inicio();
            }
        }

        static void Deposito(){
            Console.Clear();
            Senha();
            Console.WriteLine("--------DEPÓSITO---------");
            Console.WriteLine("");
            Console.WriteLine("Digite qual valor do seu depósito: ");
            float deposito = float.Parse(Console.ReadLine());
            if(deposito < 0){
                Console.WriteLine("Digite um número maior que 0");
                Console.WriteLine("Digite qualquer tecla para voltar para o inicio");
                Console.ReadKey();
                Inicio();
            }else{
                saldo = deposito + saldo;
                Console.WriteLine("DEPÓSITO FEITO COM SUCESSO");
                Console.WriteLine("Digite qualquer tecla para voltar para o inicio");
                Console.ReadKey();
                Inicio();
            }

        }

        static void Tranferencia(){
            Console.Clear();
            Senha();
            Console.WriteLine("--------TRANFERÊNCIA---------");
            Console.WriteLine("");
            Console.WriteLine("Digite o número da conta");
            float tran = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do tranferência: ");
            float valorT = float.Parse(Console.ReadLine());
            float nSaldo;
            if(valorT > saldo || valorT < 0){
                Console.WriteLine("O VALOR DA TRANFERÊNCIA É MAIOR QUE O SALDO");
                Console.WriteLine("OU O VALOR DA TRANFERÊNCIA É MENOR QUE 0");
                Console.WriteLine("Tente novamente");
                Console.WriteLine("Digite qualquer tecla para voltar para o inicio");
                Console.ReadKey();
                Inicio();
                
            }else{
                nSaldo = saldo - valorT;
                saldo = nSaldo;
                Console.WriteLine("Transferência feita com sucesso");
                Console.WriteLine("Digite qualquer tecla para voltar para o inicio");
                Console.ReadKey();
                Inicio();
            }
        }

    }
}
