using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6_PASTTRESSURE
{
    public class Car: Auto
    {
        private static int max_speed = 50;
        public override string funk1()
        {
            return "We'll never know whether it CAR or ZHIGULJ class as ZHIGULJ doesn't override anything.\nHovever, u can use this vehicle to go fishing.";
        }
        public Car()
        {
           // max_speed = 50;

            Console.WriteLine("CAR constructor");
            funk_for_nothing();
        }
        ~Car()
        {
            Console.WriteLine("CAR destruktor");
        }
        public override string funk2()
        {
            return " overrided funk 2 of car";
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
            Console.WriteLine("CAR or ZHIGULJ funk hided by using \"new\" key word");
        }
    }
}
