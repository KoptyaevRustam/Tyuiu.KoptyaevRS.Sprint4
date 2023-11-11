using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoptyaevRS.Sprint4.Task6.V4.Lib;

namespace Tyuiu.KoptyaevRS.Sprint4.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var week = new string[] { "Москва", "Санкт Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казахстан", "Самара" };
            string[] res = ds.Calculate(week);
            string[] wait = new string[] { "Москва", "Самара" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
