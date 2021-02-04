using SingleResponsibility.Principle.Models;
using System;

namespace SingleResponsibility.Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new ContaCorrentista
            {
                Nome = "João",
                Telefone = "32322121",
                CPF = "1233211234",
                Limite = 1000
            };

            Console.WriteLine("Depositando...");
            conta.Depositar(300);
            Console.WriteLine($"Saldo: {conta.Saldo}");

            Console.WriteLine("Sacando...");
            conta.Sacar(90);
            Console.WriteLine($"Saldo: {conta.Saldo}");
        }
    }
}
