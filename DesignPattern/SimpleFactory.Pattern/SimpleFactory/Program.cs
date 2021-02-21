using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipo de menssagem(Amigo ou Formal)");
            var tipo = Console.ReadLine();

            var message = MessageFactory.Instanciar(tipo);
            message.Imprimir();

            Console.ReadKey();
        }
    }
}
