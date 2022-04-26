using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6_PASTTRESSURE
{
    public class SportCar: Car
    {
        private static int max_speed = 200;
        public override string funk1()
        {
            return "This is SPORTCAR, the only one object u can use to escape from a tractorist if u're a girl in a village. FASTER!!!";
        }
        public SportCar()
        {
            //max_speed = 200;

            Console.WriteLine("SPORTCAR constructor");
            funk_for_nothing();
        }
        ~SportCar()
        {
            Console.WriteLine("SPORTCAR destruktor");
        }
        public override string funk2()
        {
            return " overrided funk 2 of sportcar";
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
            Console.WriteLine("SPORTCAR hided funk even from CAR parent class");
        }
    }
}
