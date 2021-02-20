using System;
using System.Collections.Generic;
using System.Text;

namespace ControlePagamentosRecebimentos
{
    public interface IConta
    {
        double Saldo { get;  }
        void Creditar(double valor);
        void Debitar(double valor);
        bool EhContaPagamento { get;  }
    }
}
