using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05SistemaMercado
{
    public class Cliente
    {
        public string Nome { get; }
        public string CPF { get; }
        public string Telefone { get; private set; }

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
        }

        public Cliente(string nome, string cpf, string telefone)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
        }

    }
}
