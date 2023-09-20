using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DanilovAS.Sprint1.Task2.V13.Lib;

namespace Tyuiu.DanilovAS.Sprint1.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            // 1 миля = 1.609 км
            // 1.609
            // 12 миль = 19.308 км

            DataService ds = new DataService();
            int x = 12;
            var res = ds.ConvertMilesToKm(x);
            Assert.AreEqual(19.308, res);
        }
    }
}
