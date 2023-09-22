using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DanilovAS.Sprint1.Task4.V17.Lib;

namespace Tyuiu.DanilovAS.Sprint1.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 26;
            double y = 2;
            var wait = 0.25;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res );

        }
    }
}
