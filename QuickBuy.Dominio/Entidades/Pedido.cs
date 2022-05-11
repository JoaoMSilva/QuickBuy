using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido
    {

        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        public int IdUtilizador { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string CodigoPostal { get; set; }

        public string Distrito { get; set; }

        public string Concelho { get; set; }

        public string MoradaCompleta { get; set; }

        public int NumeroPredio { get; set; }

        public int FormaPagamentoId { get; set; }

        public FormaDePagamento FormaPagamento { get; set; }

        public ICollection<ItemPedido> ItensPedido { get; set; }

    }
}
