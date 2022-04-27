using NUnit.Framework;
using System.Collections.Generic;
using Strategicheskaya_LAB_8;

namespace zTEST_LAB_8
{
    public class Tests
    {
               
        [Test]
        public void Test1()
        {
            Aeroport a = new Aeroport();
            a.AddTarrif(new Ticket("Denmark", 1500, 10));//1350
            a.AddTarrif(new Ticket("Minsk", 700));

            string sp = a.HighestPrice().Substring(a.HighestPrice().Length - 4, 4);


            Assert.AreEqual(sp, "1350");
        }

        [Test]
        public void Test2()
        {
            List<Ticket> l = new List<Ticket>(0);
            l.Add(new Ticket("a", 12, 1));
            l.Add(new Ticket("b", 45));

            

            Assert.IsTrue(l[0].GetIsOnDis());
            Assert.IsFalse(l[1].GetIsOnDis());
        }

       
    }
}