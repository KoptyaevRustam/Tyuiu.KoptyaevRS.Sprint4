using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoptyaevRS.Sprint4.Task7.V23.Lib;

namespace Tyuiu.KoptyaevRS.Sprint4.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int rows = 4;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            string str = "678135972584";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
