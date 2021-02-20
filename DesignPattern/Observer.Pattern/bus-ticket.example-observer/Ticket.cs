using System;
using System.Collections.Generic;
using System.Text;

namespace bus_ticket.example_observer
{
    class Ticket
    {
        private readonly List<ICompany> _companies = new List<ICompany>();
        private double _price;

        public Ticket(double price)
        {
            _price = price;
        }

        public void Attach(ICompany company)
        {
            _companies.Add(company);
        }

        public void Detach(ICompany company)
        {
            _companies.Remove(company);
        }

        public void Notify()
        {
            foreach (var company in _companies)
            {
                company.Update();
            }
        }

        public double Price 
        { 
            get { return _price; } 
            set 
            { 
                if(_price != value)
                {
                    _price = value;
                    Notify();
                }
            } 
        }

    }
}
