using NUnit.Framework;
using System.Collections.Generic;
using Overloaded_lab_7;

namespace zTEST_LAB_7
{
    public class Tests
    {
        
        [Test]
        public void Test1()
        {
            List<Equation> a = new List<Equation>(0);
            a.Add(new Equation(12, 0, 78));
            a.Add(new Equation(0, 0, 78));
            a.Add(new Equation(12, 0, 78));
            a.Add(new Equation(0, 16, 8));
            a.Add(new Equation(1, -2, 1));

            Assert.IsTrue(a[4] != a[3]);
        }


        [Test]
        public void Test2()
        {
            List<Equation> a = new List<Equation>(0);
            a.Add(new Equation(12, 0, 78));
            a.Add(new Equation(0, 0, 78));
            a.Add(new Equation(12, 0, 78));
            a.Add(new Equation(0, 16, 8));
            a.Add(new Equation(1, -2, 1));

            Assert.IsTrue(a[0] == a[2]);
        }

        [Test]
        public void Test3()
        {
            List<Equation> a = new List<Equation>(0);
            a.Add(new Equation(12, 0, 78));
            a.Add(new Equation(0, 0, 78));
            a.Add(new Equation(12, 0, 78));
            a.Add(new Equation(0, 16, 8));
            a.Add(new Equation(1, -2, 1));

            a[2] += a[3];

            Assert.IsFalse(a[2] != new Equation(12, 16, 86));
        }

        [Test]
        public void Test4()
        {
            List<Equation> a = new List<Equation>(0);
            a.Add(new Equation(12, 0, 78));
            a.Add(new Equation(0, 0, 78));
            a.Add(new Equation(12, 0, 78));
            a.Add(new Equation(0, 16, 8));
            a.Add(new Equation(1, -2, 1));

            string sa = "", sb = "";
            if (a[4]) sa = "true";
            if (a[0]) sb = "true";
            else sb = "false";

            Assert.AreEqual(sa + sb, "truefalse");
        }
    }
}