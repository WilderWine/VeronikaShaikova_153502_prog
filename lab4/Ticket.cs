using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletonskaya_lab4
{

    class Ticket
    {
        private string destini;
        private bool two_end;
        private static int price = 1000;
        private int sold_number;

        public Ticket() {
            destini = "Pyongyang";
            two_end = false;
        }

        private Ticket(int Price)
        {
            destini = "Pyongyang";
            two_end = false;
            price = Price;
        }
        private Ticket(string where, bool _2_end)
        {
            destini = where; two_end = _2_end;
        }

        public void SetPrice()
        {
            while (!int.TryParse(Console.ReadLine(), out price) ||
                price > int.MaxValue || price < 0) Console.WriteLine("Input Error! Try again:   ");
        }

        public void SetSoldNumber()
        {
            while (!int.TryParse(Console.ReadLine(), out sold_number) ||
                sold_number > int.MaxValue || sold_number < 0) Console.WriteLine("Input Error! Try again:   ");
        }

        public string WholeCost() 
        {
            return (price * sold_number).ToString();
        }

        public void MakeHighPrice(int val)
        {
            int a;
            
            price = price + val;
        }

        public void MakeLowerPrice(int val)
        {
            int a;
           
            price = price - val;
        }

        public int Price()
        {
            return price;
        }

        public int SoldNumber()
        {
            return sold_number;
        }

        public void Add() { sold_number++; }

    }







    /* class Ticket
    {
        private static int prise = 1000;
        private static int sold_number = 0;
        private string destination;
        private bool two_end;

        protected Ticket(string where, bool double_end)
        {
            destination = where;
            two_end = double_end;
            sold_number++;
        }
        public Ticket()
        {
            destination = "Pyongyang";
            two_end = false;
            sold_number++;
        }

        public int Prise()
        {
            return prise;
        }

        public int Sold()
        {
            return sold_number;
        }


    }*/
}
