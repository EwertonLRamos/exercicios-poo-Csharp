using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02ControleDeAnimais
{
    public class Peixe : Animal
    {
        public static int QtdPeixes { get; private set; }

        public Peixe(string nome, string tipo) : base(nome, tipo)
        {
            QtdPeixes++;
        }
    }
}
