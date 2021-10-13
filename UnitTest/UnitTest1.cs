using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Git;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cls = new Class1();
            var rez = cls.doWork(1);
            Assert.AreEqual(1, rez);
        }
    }
}
