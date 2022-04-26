using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6_PASTTRESSURE
{
    sealed public class Traktor : Auto
    {
        private static int max_speed = 20;
        public override string funk1()
        {
           return "This is an object of tractor class. You can use it to dig potatoes at your backyard or to find a girl in a village:)";
        }
        public Traktor()
        {
            //max_speed = 20;
            
            Console.WriteLine("TRAKTOR constructor");
            funk_for_nothing();
        }
        ~Traktor()
        {
            Console.WriteLine("TRAKTOR destruktor");
        }
        public override string funk2()
        {
            return " overrided funk 2 of traktor";
        }

        public override int speed()
        {
            return max_speed;
        }

        public override void SetSpeed(int sp)
        {
            max_speed = sp;
        }

        public new void NewFunk()
        {
            Console.WriteLine("TRAKTOR hided funk by using \"new\" but calling \"base\".funk()");
            base.NewFunk();
        }

    }
}
