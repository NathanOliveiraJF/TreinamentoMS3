using System;
using System.Collections.Generic;
using System.Text;

namespace ControlePagamentosRecebimentos
{
    public class RecebimentoPagamentoMovimentacao
    {
        public RecebimentoPagamentoMovimentacao(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public string Descricao { get; set; }
        public double Valor { get; set; }
    }
}
