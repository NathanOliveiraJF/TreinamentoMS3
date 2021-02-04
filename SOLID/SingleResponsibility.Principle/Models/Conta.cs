using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility.Principle.Models
{
    abstract class Conta
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public int Limite { get; set; }

        public abstract void Sacar(double valor);
        public abstract void Depositar(double valor);

    }
}
