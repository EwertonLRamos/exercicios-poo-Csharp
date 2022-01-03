using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02ControleDeAnimais
{
    public abstract class Animal
    {
        public string Nome { get; set; } 
        public string Tipo { get; set; }

        public Animal(string nome, string tipo)
        {
            Nome = nome;
            Tipo = tipo;
        }
    }
}
