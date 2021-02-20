using ControlePagamentosRecebimentos;
using System;
using Xunit;

namespace ProjetoDeTestes
{
    public class TestesConta
    {
        [Fact]
        public void NaoPodeTerSaldoNegativo()
        {
            var conta = new Conta(50);
            Assert.Throws<Exception>(() =>  conta.Debitar(100) );
        }

        [Fact]
        public void DeveDebitarValorCorretamente()
        {
            var conta = new Conta(50);
            conta.Debitar(30);
            
            Assert.Equal(20.0, conta.Saldo);

        }

        
        
    }
}
