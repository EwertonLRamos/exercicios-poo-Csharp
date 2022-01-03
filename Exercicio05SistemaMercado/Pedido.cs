using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05SistemaMercado
{
    public class Pedido
    {
        public Cliente DonoPedido { get; private set; }
        public List<Item> ItensPedido { get; private set; }
        public double PrecoPedido { get; private set; }
        public string CodPedido { get; }
        

        public Pedido(Cliente dono, Item primeiroItem, string codPedido)
        {
            DonoPedido = dono;
            CodPedido = codPedido;
            ItensPedido = new List<Item>();
            
            AdicionarItem(primeiroItem);
            PrecoPedido = CalcularPrecoPedido();
        }


        public void ExcluirItem(int codItem)
        {
            if (ItensPedido.Count > 1)
            {
                ItensPedido.RemoveAll(value =>
                {
                    if (value.CodItem == codItem)
                        return true;
                    else
                        return false;
                });
            }
            PrecoPedido = CalcularPrecoPedido();
        }

        public void AdicionarItem(Item item)
        {
            ItensPedido.Add(item);
            PrecoPedido = CalcularPrecoPedido();
        }

        public void ModificarItem(int codItem, int qtd)
        {
            for (int i = 0; i < ItensPedido.Count; i++)
            {
                if (ItensPedido[i].CodItem == codItem)
                    ItensPedido[i].QtdProdutos = qtd;
            }
            PrecoPedido = CalcularPrecoPedido();
        }

        public double CalcularPrecoPedido()
        {
            double valor = 0;
            for (int i = 0; i < ItensPedido.Count; i++)
            {
                valor += ItensPedido[i].PrecoItem;
            }
            return valor;
        }
    }
}
