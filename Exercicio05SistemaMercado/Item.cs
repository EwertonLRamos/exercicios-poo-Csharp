using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05SistemaMercado
{
    public class Item
    {
        public Produto ProdutoItem { get; }
        public int CodItem { get; }
        public int QtdProdutos { get; set; }
        public double PrecoItem { get; private set; }

        public Item(int codItem, Produto produto, int qtdProdutos)
        {
            CodItem = codItem;
            ProdutoItem = produto;
            QtdProdutos = qtdProdutos;
            PrecoItem = CalcularPrecoItem();
        }

        private double CalcularPrecoItem()
        {
            return QtdProdutos * ProdutoItem.Preco;
        }
    }
}
