using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02ControleDeAnimais
{
    public class Cachorro : Animal
    {
        public static int QtdCachorros { get; private set; }

        public Cachorro(string nome, string tipo) : base(nome, tipo)
        {
            QtdCachorros++;
        }
    }
}
