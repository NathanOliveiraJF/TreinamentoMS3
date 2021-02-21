using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.ObjetoFabricado
{
    class MensagemFormal : IMessage
    {
        public void Imprimir()
        {
            Console.WriteLine("Oi amigo\nEstá mensagem é para você!");
        }
    }
}
