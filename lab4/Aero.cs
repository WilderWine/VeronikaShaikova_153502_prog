using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletonskaya_lab4
{


   public class Aero
    {

        private int places = 0;
        private string name = "";
        private static Aero aeroport = null;
        private Ticket _base_ticket = new Ticket();

        private Aero() {
            name = "Destiny";
            places = 666;
        }
        //private Aero(string new_name, int new_places) { name = new_name; places = new_places; }
        public static Aero create()
        {
            if (aeroport == null)
            {
                aeroport = new Aero();
                return aeroport;
            }
            else return aeroport;
        }
        

        public void Rename(string _new_name)
        {
            name = _new_name;
        }
        public void NewPlaces(int number)
        {
            places = number;
        }
        public void SellNTickets()
        {
            _base_ticket.SetSoldNumber();
        }
        public void ChangePrice()
        {
            _base_ticket.SetPrice();
        }
        public string CostOfSold()
        {
            return _base_ticket.WholeCost();
        }
        public void MakeLoverPrice(int val)
        {
            _base_ticket.MakeLowerPrice(val);
        }
        public void MakeHigherPrice(int val)
        {
            _base_ticket.MakeHighPrice(val);
        }
        public int Places()
        {
            return places;
        }
        public string Name() { return name; }
        public int Sold()
        {
            return _base_ticket.SoldNumber();
        }
        public int Price()
        {
             return _base_ticket.Price(); 
        }



        public void SellTicket()
        {

            _base_ticket.Add();
        }

       /* public int SoldNumber()
        {
            Ticket a = new Ticket();
            
            return a.Sold();
        }

        public Ticket Ticket(string destination, bool both_end)
        {
            return new Ticket(destination, both_end);
        }


        public int WholeCost()
        {
            
            return Ticket.Prise() * ticket.Sold();
        }*/
      
       


        
        



    }
}
