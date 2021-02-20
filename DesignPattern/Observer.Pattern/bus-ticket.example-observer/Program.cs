using System;

namespace bus_ticket.example_observer
{
    class Program
    {
        static void Main(string[] args)
        {
            //passagem de onibus
            Ticket ticket = new Ticket(3.75);

            //Empresas de onibus
            ticket.Attach(new Company(ticket, "São Francisco"));
            ticket.Attach(new Company(ticket, "Ansal"));
            ticket.Attach(new Company(ticket, "Tusmil"));

            //alterando passagem e notificando as empresas.
            ticket.Price = 4.0;
            ticket.Price = 5.0;
            ticket.Price = 5.75;

        }
    }
}
