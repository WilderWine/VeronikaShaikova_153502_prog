using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategicheskaya_LAB_8
{
    public class Ticket
    {
        private IPrice _price;
        private string _destination = "";
        public Ticket(string dest, int pr)
        {
            _destination = dest;
            _price = new FullPrice(pr);
        }
        public Ticket(string dest, int pr, int dis)
        {
            _destination = dest;
            _price = new DisPrice(pr, dis);
        }

        public int GetPrice()
        {
            return _price.GetPrice();
        }

        public string GetInfo()
        {
            return "Destination:\t"+_destination + "\n" +
            _price.GetInfo();
        }

        public bool GetIsOnDis()
        {
            return _price.GetIsOnDis();
        }

    }
}
