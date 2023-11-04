using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoptyaevRS.Sprint4.Task1.V23.Lib;

namespace Tyuiu.KoptyaevRS.Sprint4.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 6, 3, 2, 9, 7, 5, 1 };
            int res = ds.Calculate(numsArray);
            int wait = 12;

            Assert.AreEqual(wait, res);
        }
    }
}
