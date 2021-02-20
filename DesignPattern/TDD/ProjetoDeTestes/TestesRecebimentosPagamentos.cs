using ControlePagamentosRecebimentos;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
namespace ProjetoDeTestes
{
    public class TestesRecebimentosPagamentos
    {
        [Theory]
        [InlineData(100)]
        [InlineData(30)]
        public void PrecisaDebitarContaNoPagamento(double valor)
        {
            var mock = new Mock<IConta>();
            mock.Setup(x => x.EhContaPagamento).Returns(true);

            var pagToReceb = new RecebimentosPagamentos(mock.Object);
            pagToReceb.Pagar("Conta de Luz", valor);
            mock.Verify(x => x.Debitar(valor), Times.Once);
          
        }

        [Fact]
        public void SoPodeDebitarContaSeParaPagamento()
        {
            var valor = 150.0;
            var mock = new Mock<IConta>();
            mock.Setup(x => x.EhContaPagamento).Returns(false);

            var pagToReceb = new RecebimentosPagamentos(mock.Object);

            mock.Verify(x => x.Debitar(valor), Times.Never);
            Assert.Throws<Exception>(() => pagToReceb.Pagar("Conta de Luz", valor));

        }

        [Fact]
        public void PrecisaRegistrarMovimentacaoPagamento()
        {
            var valor = 150.0;
            var descricao = "Conta de Luz";
            var mock = new Mock<IConta>();
            mock.Setup(x => x.EhContaPagamento).Returns(true);
          
            var pagtoReceb = new RecebimentosPagamentos(mock.Object);
            pagtoReceb.Pagar(descricao, valor);
            var movi = pagtoReceb.Movimentacoes.Where(x => x.Descricao.Equals(descricao) && x.Valor == valor);

            Assert.True(movi.Count() == 1);
        }
    }
}
