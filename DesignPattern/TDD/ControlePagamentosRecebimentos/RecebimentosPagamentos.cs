using System;
using System.Collections.Generic;
using System.Text;

namespace ControlePagamentosRecebimentos
{
    public class RecebimentosPagamentos
    {
        private IConta _conta;
        private List<RecebimentoPagamentoMovimentacao> movimentacaos;

        public RecebimentosPagamentos(IConta conta)
        {
            _conta = conta;
            movimentacaos = new List<RecebimentoPagamentoMovimentacao>();
        }

        public IEnumerable<RecebimentoPagamentoMovimentacao> Movimentacoes => movimentacaos;


        public void Pagar(string descricao, double valor)
        {
            if (!_conta.EhContaPagamento)
                throw new Exception("Essa conta é para pagamento");

            _conta.Debitar(valor);
            movimentacaos.Add(new RecebimentoPagamentoMovimentacao(descricao, -valor));
        }

        public void Receber(string descricao, double valor)
        {
            _conta.Creditar(valor);
            movimentacaos.Add(new RecebimentoPagamentoMovimentacao(descricao, valor));

        }

       
    }
}
