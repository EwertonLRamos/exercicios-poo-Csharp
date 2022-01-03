using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02ControleDeAnimais
{
    public class Gato : Animal
    {
        public static int QtdGatos { get; private set; }

        public Gato(string nome, string tipo) : base(nome, tipo)
        {
            QtdGatos++;
        }
    }
}
