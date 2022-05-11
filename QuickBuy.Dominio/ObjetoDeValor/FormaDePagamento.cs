using QuickBuy.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaDePagamento
    {

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public bool IsCartaoCredito
        {
            get { return Id == (int)TipoFormaDePagamentoEnum.CartaoCredito; }
        }

        public bool IsTransferenciaBancaria
        {
            get { return Id == (int)TipoFormaDePagamentoEnum.TransferenciaBancaria; }
        }

        public bool NotDefined
        {
            get { return Id == (int)TipoFormaDePagamentoEnum.NaoDefinido; }
        }

    }
}
