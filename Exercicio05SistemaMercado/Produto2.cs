using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05SistemaMercado
{
    public class Produto2 : Produto
    {
        private static int _qtdEstoque = 10;

        public override double Preco { get; set; }
        public override int CodProduto { get; }
        public override int QtdEstoque
        {
            get
            {
                return _qtdEstoque;
            }
        }


        public Produto2(double preco, int codProduto)
        {
            Preco = preco;
            CodProduto = codProduto;

            _qtdEstoque--;
        }


        public override void AtualizarPreco(double novoPreco)
        {
            Preco = novoPreco;
        }

        public override void AtualizarQtdEstoque()
        {
            _qtdEstoque = 10;
        }
    }
}
