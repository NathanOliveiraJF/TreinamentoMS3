using SimpleFactory.ObjetoFabricado;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SimpleFactory
{
    class MessageFactory
    {
        public static IMessage Instanciar(string tipo)
        {
            //executável
            var assembly = Assembly.GetExecutingAssembly();
            
            //caminho da classe
            var classe = assembly.GetType($"SimpleFactory.ObjetoFabricado.Mensagem{tipo}");

            if (classe == null)
                throw new Exception("Invalid Message!");

            //obtém construtor
            var constructor = classe.GetConstructor(Type.EmptyTypes);

            //cria o objeto e converte para imessage.
            return (IMessage)constructor.Invoke(new object[] { });
        }
    }
}
