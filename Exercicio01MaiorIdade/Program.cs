using System;

namespace Exercicio01MaiorIdade
{
    class Program
    {

        static void Main(string[] args)
        {
            Pessoa[] pessoas = new Pessoa[3];

            string nomeAux;
            int idadeAux;
            int indiceMaior = 0;
            int contIguais = 0;

            for (int i = 0; i < pessoas.Length; i++)
            {
                Console.WriteLine((i + 1) + "° Pessoa");
                
                Console.Write("Escreva o nome: ");
                nomeAux = Console.ReadLine();

                Console.Write("Escreva a idade: ");
                idadeAux = int.Parse(Console.ReadLine());

                pessoas[i] = new Pessoa(nomeAux, idadeAux);
                Console.WriteLine();
            }

            for (int i = 0; i < pessoas.Length; i++)
            {
                if (pessoas[i].Idade > pessoas[0].Idade)
                    indiceMaior = i;

                if (pessoas[i].Idade == pessoas[0].Idade)
                    contIguais++;
            }

            if (contIguais >= 3)
                Console.WriteLine("Todos tem a mesma idade");
            else
            {
                Console.WriteLine("Pessoa com maior idade:");
                pessoas[indiceMaior].ExibirDados();
            }

            Console.ReadLine(); 
        }
    }
}
