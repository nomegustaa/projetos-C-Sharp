using System;

namespace Calculator{
    
    class Program{
        
        static void Main(string[] args){
            Menu();
        }

        static void Menu(){
            Console.Clear();

            Console.WriteLine("======================");
            Console.WriteLine("   CALCULADORA");
            Console.WriteLine("======================");

            Console.WriteLine("Qual operação deseja realizar: ");
            Console.WriteLine("[1] - Soma");
            Console.WriteLine("[2] - Subtração");
            Console.WriteLine("[3] - Divisão");
            Console.WriteLine("[4] - Multiplicação");
            Console.WriteLine("[5] - Sair");

            Console.WriteLine("======================");

            short res = short.Parse(Console.ReadLine());

            switch(res){
                case 1: Soma(); break;

                case 2: Subtracao(); break;

                case 3: Divisao(); break;

                case 4: Multiplicacao(); break;

                case 5: System.Environment.Exit(0); break;

                default: Menu(); break;
            }


        }

        static void Soma(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao(){
            Console.Clear();
            
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado_sub = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {resultado_sub}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao(){
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado_div = v1 / v2;
            Console.WriteLine($"O resultado da divisão é {resultado_div}");

            Console.ReadKey();
            Menu();

        }

        static void Multiplicacao(){
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado_mult = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é {resultado_mult}");

            Console.ReadKey();
            Menu();
        }
    }
}
