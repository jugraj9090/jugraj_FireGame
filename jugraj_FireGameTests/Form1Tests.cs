using Microsoft.VisualStudio.TestTools.UnitTesting;
using jugraj_FireGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jugraj_FireGame.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Module obj = new Module();
            int y = obj.shotTest(1);
            if (y == 1)
            {
                Assert.IsTrue(true);

            }
            else {
                Assert.IsTrue(false);
            }

        }

        [TestMethod()]
        public void Form2Test()
        {
            Module obj = new Module();
            obj.fireGun();
            Assert.IsTrue(true);
            

        }



    }
}