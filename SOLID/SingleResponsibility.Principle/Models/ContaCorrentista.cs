using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility.Principle.Models
{
    class ContaCorrentista : Conta
    {
     
        public override void Depositar(double valor) => Saldo += valor;

        public override void Sacar(double valor)
        {
            if (Saldo + Limite < valor)
                throw new Exception("Saldo insuficiente.");

            Saldo -= valor;
        }
    }
}
