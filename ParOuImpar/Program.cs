using System;

namespace ParOuImpar{
    
    class Program{
        static void Main(string[]args){

            Console.Clear();
            Console.WriteLine("Descubra se o número é par ou impar");
            Console.WriteLine("");
            Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine());
            int soma = num%2;
            if(soma == 0){
                Console.WriteLine($"O número {num} é PAR");
                Console.WriteLine("Digite qualquer tecla para sair");
                Console.ReadKey();
            }else{
                Console.WriteLine($"O número {num} é ÍMPAR");
                Console.WriteLine("Digite qualquer tecla para sair");
                Console.ReadKey();
            }
        }
    }
}