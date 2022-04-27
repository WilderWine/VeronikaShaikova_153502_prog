using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategicheskaya_LAB_8
{
    class DisPrice : IPrice
    {
        private int _price = 0, _discount = 0;
        private bool _disc = true;

        public DisPrice(int pr, int dis)
        {
            _price = pr - pr*dis/100;
            _discount = dis;
        }
        
        public int GetPrice()
        {
            return _price;
        }

        public string GetInfo()
        {
            return "Ticket has a discount\nPrice:\t" + _price.ToString() + "\tDiscount:\t" + _discount.ToString() + "%";
        }

        public bool GetIsOnDis()
        {
            return _disc;
        }

    }
}
