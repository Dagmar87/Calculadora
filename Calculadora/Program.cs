using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            bool endApp = false;

           // Exibe o título como o aplicativo de calculadora do console C #.
            Console.WriteLine("Calculadora de Console em C#\r");
            Console.WriteLine("------------------------\n");

            while(!endApp)
            {
                // Declare variáveis e defina como vazio.
                string nInp1 = "";
                string nInp2 = "";
                double res = 0;

                // Peça ao usuário para digitar o primeiro número.
                Console.Write("Digite um número e pressione Enter: ");
                nInp1 = Console.ReadLine();

                double cleanN1 = 0;
                while(!double.TryParse(nInp1, out cleanN1))
                {
                    Console.Write("Esta não é uma entrada válida. Por favor insira um valor inteiro: ");
                    nInp1 = Console.ReadLine();
                }

                // Peça ao usuário para digitar o segundo número.
                Console.Write("Digite outro número e pressione Enter: ");
                nInp2 = Console.ReadLine();

                double cleanN2 = 0;
                while (!double.TryParse(nInp2, out cleanN2))
                {
                    Console.Write("Esta não é uma entrada válida. Por favor insira um valor inteiro: ");
                    nInp2 = Console.ReadLine();
                }

                // Peça ao usuário para escolher uma opção.
                Console.WriteLine("Escolha uma opção da seguinte lista:");
                Console.WriteLine("\ta - Adição");
                Console.WriteLine("\ts - Subtração");
                Console.WriteLine("\tm - Multiplicação");
                Console.WriteLine("\td - Divisão");
                Console.Write("Sua opção?");

                string op = Console.ReadLine();

                try
                {
                    res = Calculadora.DoOperation(cleanN1, cleanN2, op);
                    if (double.IsNaN(res))
                    {
                        Console.WriteLine("Esta operação resultará em um erro matemático.\n");
                    }
                    else Console.WriteLine("Seu resultado: {0:0.##}\n", res);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Ah não! Ocorreu uma exceção ao tentar fazer as contas.\n - Detalhes: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Aguarde a resposta do usuário antes de fechar.
                Console.Write("Pressione 'n' e Enter para fechar o aplicativo ou pressione qualquer outra tecla e Enter para continuar: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Espaçamento de linha amigável.
            }
            return;
        }
    }
}
