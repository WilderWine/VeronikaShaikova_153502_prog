using NUnit.Framework;
using AEROPORT_LAB_5;

namespace ZTEST_LAB_5
{
    public class Tests
    {
        
        [Test]
        public void Test1()
        {
            Airport1 h = new Airport1();
            h.AddTicket("a", 100);
            h.AddTicket("b", 200);
            h.AddTicket("c", 300);

            Tarrif_aka_Ticket k = new Tarrif_aka_Ticket("k", 777);
            Airport1.GetTicketList().Add(k);

            Assert.AreEqual(Airport1.GetTicketList().Count, 4);
      
        }

        [Test]
        public void Test2()
        {
            Airport1 h = new Airport1();
            customer ilya = new customer("ilya", "kb4112555", CType.standart);
            Airport1.GetCustomers().Add(ilya);
            h.AddCustomer("natan", "FR14545", CType.VIP);
            h.AddCustomer("AAAAAAAAAAAAAAAAAAAAAAAAAA", "NoPass", CType.child);

            Assert.AreEqual(Airport1.GetCustomers().Count, 3);

        }

        [Test]
        public void Test3()        {
            Airport1 h = new Airport1();
            h.AddTicket("a", 100);
            h.AddTicket("b", 200);
            h.AddTicket("c", 300);

            Tarrif_aka_Ticket k = new Tarrif_aka_Ticket("k", 777);
            Airport1.GetTicketList().Add(k);

           
            customer ilya = new customer("ilya", "kb4112555", CType.standart);
            

            ilya.BuyTicket("b");
            ilya.BuyTicket("a");
            ilya.BuyTicket("k");
            ilya.BuyTicket("a");

            Assert.AreEqual(ilya.Sum(), 1177);
        }

        [Test]
        public void Test4()
        {
            Airport1 h = new Airport1();
            h.AddTicket("a", 100);
            h.AddTicket("b", 200);
            h.AddTicket("c", 300);

            


            customer ilya = new customer("ilya", "kb4112555", CType.standart);
            Airport1.GetCustomers().Add(ilya);
            h.AddCustomer("natan", "FR14545", CType.VIP);
            h.AddCustomer("AAAAAAAAAAAAAAAAAAAAAAAAAA", "NoPass", CType.child);

            ilya.BuyTicket("b");
            Airport1.GetCustomers()[1].BuyTicket("c");
            Airport1.GetCustomers()[1].BuyTicket("b");
            Airport1.GetCustomers()[2].BuyTicket("a");

            Assert.AreEqual(h.GetWholeCost(), 800);
        }
    }
}