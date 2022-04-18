using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEROPORT_LAB_5
{
   public class Tarrif_aka_Ticket
    {
        string destination;
        int price;
        public Tarrif_aka_Ticket(string a, int b)
        {
            destination = a;
            price = b;
        }
        public string Destination()
        {
            return destination;
        }
        public int Price()
        {
            return price;
        }
    }
}
