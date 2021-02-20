using System;
using System.Collections.Generic;
using System.Text;

namespace ControlePagamentosRecebimentos
{
    public class Conta : IConta
    {
        public double Saldo { get; set; }


        public Conta(double saldo)
        {
            Saldo = saldo;
        }
        public void Creditar(double valor)
        {
            Saldo += valor;
        }

        public void Debitar(double valor)
        {
            if (valor > Saldo)
                throw new Exception("Saldo Insuficiente");

            Saldo -= valor;
        }

        public bool EhContaPagamento { get; set; }

    }
}
