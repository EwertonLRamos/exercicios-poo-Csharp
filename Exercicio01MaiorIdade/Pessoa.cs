using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01MaiorIdade
{
    public class Pessoa
    {
        private int _idade;

        public string Nome { get; set; }
        public int Idade
        {
            get
            {
                return _idade; 
            }
            set
            {
                if (value > 0)
                    _idade = value;
                else
                    _idade = 0;
            }
        }

        public Pessoa() {  }

        public Pessoa(string nome, int idade) 
        {
            Nome = nome;
            Idade = idade;
        }

        public void ExibirDados() 
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + Idade);
        }
    }
}
