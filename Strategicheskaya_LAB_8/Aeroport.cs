using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategicheskaya_LAB_8
{
    [Obsolete()]
    public class Aeroport
    {
        private List<Ticket> tickets = new List<Ticket>(0);

       

        public void FullInfo()
        {
            int whole_cost = 0, i = 1;
            string info = "";
            foreach(Ticket ticket in tickets)
            {
                whole_cost += ticket.GetPrice();
                info += "№" + i.ToString() + "\n" + ticket.GetInfo() + "\n";
                i++;
            }
           
            Console.WriteLine(info + "\n~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~\nTotal Cost:\t" + whole_cost.ToString());
            Console.WriteLine(HighestPrice());
            Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ");
        }

        public void AddTarrif(Ticket tick)
        {
            tickets.Add(tick);
        }

        public string HighestPrice()
        {
            return "Highest price:\t" + (tickets.Max(ticket => ticket.GetPrice())).ToString();
        }

    }
}
