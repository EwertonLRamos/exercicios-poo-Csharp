using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04CriarPessoa
{
    public class Pessoa
    {
        public string Nome { get; }
        public DateTime DataNasc { get; }
        public double Altura { get; set; }

        public Pessoa(string nome, DateTime dataNasc, double altura)
        {
            Nome = nome;
            Altura = altura;
            DataNasc = dataNasc;
        }
        
        public void EscreverDados() 
        {
            Console.WriteLine("Dados da pessoa\n");
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Data Nasc.: " + DataNasc);
            Console.WriteLine("Altura: " + Altura);
            Console.WriteLine("Idade: " + CalcularIdade());
        }

        public int CalcularIdade()
        {
            return DateTime.Today.Year - DataNasc.Year;
        }
    }
}
