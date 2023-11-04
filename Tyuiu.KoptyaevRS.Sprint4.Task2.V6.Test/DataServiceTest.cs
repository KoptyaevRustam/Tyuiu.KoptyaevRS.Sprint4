using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoptyaevRS.Sprint4.Task2.V6.Lib;

namespace Tyuiu.KoptyaevRS.Sprint4.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 2, 6, 7, 5, 4, 3 };

            int res = ds.Calculate(numsArray);
            int wait = 105;

            Assert.AreEqual(wait, res);
        }
    }
}
