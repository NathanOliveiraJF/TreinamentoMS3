using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj1 = Configuration.Instancia;
            var obj2 = Configuration.Instancia;

            if (obj1 == obj2)
                Console.WriteLine("Mesma referência");
        }
    }
}
