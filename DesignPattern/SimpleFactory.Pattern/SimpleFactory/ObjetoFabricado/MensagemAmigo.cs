using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.ObjetoFabricado
{
    class MensagemAmigo : IMessage
    {
        public void Imprimir()
        {
            Console.WriteLine("Oi amigo, está mensagem é para você");
        }
    }
}
