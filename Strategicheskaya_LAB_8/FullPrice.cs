using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategicheskaya_LAB_8
{
    class FullPrice : IPrice
    {
        private int _price = 0;
        private bool _disc = false;

        public FullPrice(int pr)
        {
            _price = pr;
        }

        public int GetPrice()
        {
            return _price;
        }

        public string GetInfo()
        {
            return "Ticket does NOT have a discount\nPrice:\t" + _price.ToString();
        }

        public bool GetIsOnDis()
        {
            return _disc;
        }
    }
}
