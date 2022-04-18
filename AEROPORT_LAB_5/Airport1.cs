using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEROPORT_LAB_5
{
   public class Airport1
    {
       private static List<Tarrif_aka_Ticket> poss = new List<Tarrif_aka_Ticket>(0);
       private static List<customer> customers = new List<customer>(0);
        private int currentCus = 0;
       public void AddTicket(string dest, int pr)
        {
            Tarrif_aka_Ticket a = new Tarrif_aka_Ticket(dest, pr);
            poss.Add(a);
        }
        public static List<Tarrif_aka_Ticket> GetTicketList() 
        { 
            return poss; 
        }

        public static List<customer> GetCustomers()
        {
            return customers;
        }

        public int GetWholeCost()
        {
            int sum = 0;
            for(int i = 0; i < customers.Count(); i++)
            {
                sum += customers[i].Sum();
            }
            return sum;
        }

        public void AddCustomer(string n, string p, CType t)
        {
            customer cus = new customer(n, p, t);
            customers.Add(cus);
        }

        public void LogIn(int val)
        {
            currentCus = val - 1;
        }
        public void LogOut()
        {
            currentCus = 0;
        }

        public string SearchName(string name)
        {
            string str = ""; int ind = 0;
            for(int i = 0; i < customers.Count; i++)
            {
                if (name == customers[i].name)
                {
                    ind = i; break;
                }
            }
            str += "\n" + customers[ind].Sum().ToString()
                + "\n" + customers[ind].name + "[" + customers[ind].GetTyype() + "]" + "\n" + customers[ind].passp
                + "\n" + customers[ind].ListT();
            return str;
        }

        /*public string SearchDest(string dest)
        {
            string str  = ""; int ind = 0, pric = 0;
            for (int i = 0; i < poss.Count; i++)
            {
                if (dest == poss[i].Destination())
                {
                    ind = i;
                    pric = poss[i].Price();
                    break;
                }
            }
            str += "Price:\t" + pric.ToString() + "\n" + "Destination:\t" + dest +
                "\n" + "Bought:\n";
            for(int i = 0; i < customers.Count; i++)
            {
                bool f = false;
                for(int j = 0; j < )
            }


            return str;
        }*/
        public string Customerrrs()
        {
            string str = "";

            for(int i = 0; i < customers.Count; i++)
            {
                str += "\n" + (i + 1).ToString() + ":\t" + customers[i].name;
            }


            return str;
        }
        public string Tickeeets()
        {
            string str = "";

            for (int i = 0; i < poss.Count; i++)
            {
                str += "\n" + (i + 1).ToString() + ":\t" + poss[i].Destination();
            }


            return str;
        }

        public void SellTicket(int val)
        {
            customers[currentCus].BuyTicket(poss[val - 1].Destination());
        }

    }
}
