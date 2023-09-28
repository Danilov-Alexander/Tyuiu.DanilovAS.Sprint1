using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DanilovAS.Sprint1.Task7.V30.Lib;

namespace Tyuiu.DanilovAS.Sprint1.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            var wait = ds.Calculate(x, y);
            double res = 12.291;
            Assert.AreEqual(wait, res);
            



        }
    }
}
