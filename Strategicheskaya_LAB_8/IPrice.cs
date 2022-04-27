using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategicheskaya_LAB_8
{
    interface IPrice
    {
        public int GetPrice();
        public string GetInfo();

        public bool GetIsOnDis();
    }
}
