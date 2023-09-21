using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DanilovAS.Sprint1.Task0.V3.Lib;

namespace Tyuiu.DanilovAS.Sprint1.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(1, res);        }
    }
}
