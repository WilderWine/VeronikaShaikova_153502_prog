using System;

using Xunit;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            
            string a = "35";
            string b = "7";
            

            float c = float.Parse(a);
            float d = float.Parse(b);

            float trd_val = c / d;

            Assert.Equal(5, trd_val);




        }
        [Fact]
        public void Test2()
        {
            string a = "1";
            string b = "1";
            

            float c = float.Parse(a);
            float d = float.Parse(b);

            float trd_val = c / d;

            Assert.Equal(1, trd_val);
        }

        [Fact]
        public void Test3()
        {
            string a = "1,8";
            string b = "3,6";


            float c = float.Parse(a);
            float d = float.Parse(b);

            float trd_val = c / d;

            Assert.Equal(0.5, trd_val);
        }

     
    }
}
