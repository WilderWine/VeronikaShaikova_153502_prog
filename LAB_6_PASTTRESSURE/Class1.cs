using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6_PASTTRESSURE
{
    abstract public class Auto
    {
        private int max_speed = 5;
        
        abstract public string funk1();
        public virtual string funk2() {
            return "funk 2 of abstract class";
        }

        public virtual int speed()
        {
            return max_speed * 5;
        }

        public Auto()
        {
            Console.WriteLine("BASE CLASS constructor");
           // funk_for_nothing();
        }

         ~Auto()
        {
            Console.WriteLine("BASE CLASS destructor");
        }

        public static void funk_for_nothing()
        {
            Console.WriteLine("not overrided funk back from BASE CLASS");
        }

        public void NewFunk()
        {
            Console.WriteLine("BASE funk to be hiden");
        }

        public virtual void SetSpeed(int sp)
        {
            max_speed = sp;
        }
    }
}
