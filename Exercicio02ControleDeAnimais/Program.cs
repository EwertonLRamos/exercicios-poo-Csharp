using System;

namespace Exercicio02ControleDeAnimais
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animais = new Animal[5];

            string nome;
            string tipo;

            for (int i = 0; i < animais.Length; i++)
            {
                Console.WriteLine("Para o " + (i + 1) + "° animal:");
                Console.Write("Nome: ");
                nome = Console.ReadLine().ToLower();
                Console.Write("Tipo: ");
                tipo = Console.ReadLine().ToLower();
                Console.WriteLine();

                animais[i] = tipo switch
                {
                    "cachorro" => new Cachorro(nome, tipo),
                    "gato" => new Gato(nome, tipo),
                    _ => new Peixe(nome, tipo),
                };
            }

            Console.WriteLine("Temos então:");
            Console.WriteLine(Cachorro.QtdCachorros + " Cachorro(s)");
            Console.WriteLine(Gato.QtdGatos + " Gato(s)");
            Console.WriteLine(Peixe.QtdPeixes + " Peixe(s)");

            Console.ReadLine();
        }
    }
}
