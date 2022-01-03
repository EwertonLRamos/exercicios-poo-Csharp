using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05SistemaMercado
{
    public abstract class Produto
    {
        public abstract double Preco { get; set; }
        public abstract int QtdEstoque { get; }
        public abstract int CodProduto { get; }

        public abstract void AtualizarQtdEstoque();
        public abstract void AtualizarPreco(double novoPreco);
    }
}
