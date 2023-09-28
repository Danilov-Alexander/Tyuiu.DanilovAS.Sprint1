using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DanilovAS.Sprint1.Task5.V5.Lib;


namespace Tyuiu.DanilovAS.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressiong()
        {
            DataService ds = new DataService();
            double x = 32.597;
            int wait = 5;
            double res = ds.Calculate(x);
            int result = Convert.ToInt32(res);
            Assert.AreEqual(wait, result);
        }
    }
}
