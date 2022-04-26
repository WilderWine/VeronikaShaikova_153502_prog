using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6_PASTTRESSURE
{
    public sealed class Zhigulj : Car
    {
        private static int max_speed = 50;
        public override string funk1()
        {
            return "This is an object of CAR or ZHIGULJ class. This is primary car still u'll be cool with it in the forest:)";
        }
        public Zhigulj()
        {
            //max_speed = 50;

            Console.WriteLine("ZHIGULJ constructor");
            funk_for_nothing();
        }
        ~Zhigulj()
        {
            Console.WriteLine("ZHIGUL destruktor");
        }
        
    }
}
