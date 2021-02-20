using System;
using System.Collections.Generic;
using System.Text;

namespace bus_ticket.example_observer
{
    class Company : ICompany
    {
        private Ticket _ticket;
        private string _name;

        public string Name 
        { 
            get => _name; 
            private set => _name = value; 
        }
        public Ticket Ticket
        {
            get => _ticket;
            private set => _ticket = value;
        }

        public Company(Ticket ticket, string name)
        {
            _name = name;
            _ticket = ticket;
        }

        public void Update()
        {
            Console.WriteLine($"- Empresa: {_name}\n- Preço Passagem Alterada: {_ticket.Price:C}\n");
        }

    }
}
