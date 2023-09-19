using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DanilovAS.Sprint1.Task1.V15.Lib;

namespace Tyuiu.DanilovAS.Sprint1.Task1.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpession()
        {
            DataService ds = new DataService();
            double x = 5.0;
            var res = ds.Calculate(x) ;
            Assert.AreEqual(2, res);
        }
    }
}
