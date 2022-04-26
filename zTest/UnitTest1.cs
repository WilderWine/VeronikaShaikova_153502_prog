using NUnit.Framework;
using LAB_6_PASTTRESSURE;

namespace zTest
{
    public class Tests
    {
       

        [Test]
        public void Test1()
        {

            Traktor j = new Traktor();

            j.SetSpeed(45);



            Assert.AreEqual(45, j.speed());
        }

        [Test]
        public void Test2()
        {

            Zhigulj j = new Zhigulj();

            j.SetSpeed(45);

            Car i = new Car();

            Assert.AreEqual(45, i.speed());
        }

        [Test]
        public void Test3()
        {

            Traktor traktor = new Traktor();

            string a = "This is an object of tractor class. You can use it to dig potatoes at your backyard or to find a girl in a village:)";

            Assert.AreEqual(a, traktor.funk1()) ;
        }

        [Test]
        public void Test4()
        {

            string a = " overrided funk 2 of sportcar";

            SportCar cat = new SportCar();

            Assert.AreEqual(a, cat.funk2());
        }
    }
}