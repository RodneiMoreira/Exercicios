using System;

namespace NovaCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calculadora Acao");

            Calculadora acao = new Calculadora();

            Console.WriteLine("digite um número");

            decimal num1 = Convert.ToDecimal(Console.ReadLine());

            while (true)
            {

                Console.WriteLine("digite outro numero");

                decimal num2 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("escolha uma operaçao");

                Console.WriteLine("A) para adição");
                Console.WriteLine("B) para subtração");
                Console.WriteLine("C) para multiplicação");
                Console.WriteLine("D) para divisão");
                Console.WriteLine("E) para terminar");

                decimal resultado = 0;

                string operadorEscolhido = Console.ReadLine();

                if (operadorEscolhido == "A" || operadorEscolhido == "a")
                {
                    resultado = acao.somar(num1, num2);
                }
                else if (operadorEscolhido == "B" || operadorEscolhido == "b")
                {
                    resultado = acao.subtrair(num1, num2);
                }
                else if (operadorEscolhido == "C" || operadorEscolhido == "c")
                {
                    resultado = acao.multiplicar(num1, num2);
                }
                else if (operadorEscolhido == "D" || operadorEscolhido == "d")
                {
                    resultado = acao.dividir(num1, num2);
                }
                else if (operadorEscolhido == "E" || operadorEscolhido == "e")
                {
                    return;
                }

                Console.WriteLine("o resultado é");

                Console.WriteLine(resultado);

                Console.WriteLine("deseja continuar (S/N)?");

                string escolha = Console.ReadLine();

                if (escolha == "S" || escolha == "s")
                {
                    num1 = resultado;
                }
                else if (escolha == "N" || escolha == "n")
                {
                    Console.WriteLine("Obrigado por utilizar esta calculadora");

                    Console.ReadKey();
                    break;
                }

            }

        }
    }
}
