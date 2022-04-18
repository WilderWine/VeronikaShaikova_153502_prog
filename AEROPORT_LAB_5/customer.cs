using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEROPORT_LAB_5
{
   public enum CType{VIP, standart, child}
   public class customer
    {
        private List<Tarrif_aka_Ticket> tickets = new List<Tarrif_aka_Ticket>(0);
        public string name;
        public string ctype;
        public string passp;
        public customer(string name, string passp, CType type)
        {
            this.passp = passp;
            this.name = name;
            switch (type)
            {
                case CType.child:
                    {
                        ctype = "child";
                        break;
                    }
                case CType.VIP:
                    {
                        ctype = "VIP";
                        break;
                    }
                case CType.standart:
                    {
                        ctype = "standart";
                        break;
                    }
            }
        }

        public void BuyTicket(string Ticket)
        {
            string a = ""; int b = 0;
            for(int i = 0; i<Airport1.GetTicketList().Count; i++)
            {
                if(Ticket == Airport1.GetTicketList()[i].Destination())
                {
                    a = Ticket;
                    b = Airport1.GetTicketList()[i].Price();
                }
            }

            Tarrif_aka_Ticket t = new Tarrif_aka_Ticket(a, b);
            tickets.Add(t);
        }

        public string ListT()
        { 
            string str = "";
            for(int i = 0; i < tickets.Count(); i++)
            {
                str += tickets[i].Destination() + "\t"+ tickets[i].Price().ToString() + "\n";
            }
            return str + "\n";
        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < tickets.Count; i++)
            {
                sum += tickets[i].Price();
            }
            return sum;
        }

        public string  GetTyype()
        {
            return ctype;
        }
        
    }
}
