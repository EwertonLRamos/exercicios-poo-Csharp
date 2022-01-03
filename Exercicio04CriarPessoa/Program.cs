using System;

namespace Exercicio04CriarPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa;
            string nome;
            DateTime dataNasc;
            double altura;

            string[] txtDataNasc = { "Dia: ", "Mês: ", "Ano: " };
            int[] valDataNasc = new int[3];
            
            Console.WriteLine("Preencha os dados da pessoa");

            Console.Write("\nNome: ");
            nome = Console.ReadLine();

            Console.WriteLine("\nData de Nascimento");
            for (int i = 0; i < txtDataNasc.Length; i++)
            {
                Console.Write(txtDataNasc[i]);
                valDataNasc[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nAltura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            dataNasc = new DateTime(valDataNasc[2], valDataNasc[1], valDataNasc[0]);
            pessoa = new Pessoa(nome, dataNasc, altura);

            pessoa.EscreverDados();

            Console.ReadKey();
        }
    }
}
