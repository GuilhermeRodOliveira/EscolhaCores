using System;

namespace EXERCICIOS_ESTRUTURA_CONDICIONAIS_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6 - Faça um programa que peça ao usuário para digitar o nome de uma cor e, em seguida, verifique se a cor é "vermelho", "azul" ou "verde".
            Console.WriteLine("Temos 3 cores no nosso sistema:\n Vermelho \n Azul \n Verde.");
            Console.WriteLine("Escreva por extenso a cor que deseja.");

            string cor = Console.ReadLine();

            if (cor.ToLower() == "vermelho")
            {
                Console.WriteLine($"A cor selecionada foi {cor}");
            }
            else if (cor.ToLower() == "azul")
            {
                Console.WriteLine($"A cor selecionada foi {cor}");
            }
            else if (cor.ToLower() == "verde")
            {
                Console.WriteLine($"A cor selecionada foi {cor}");
            }
            else
            {
                Console.WriteLine($"Erro: A cor {cor} não é suportada. Por favor, escolha entre vermelho, azul ou verde.");
            }
        }
    }
}
