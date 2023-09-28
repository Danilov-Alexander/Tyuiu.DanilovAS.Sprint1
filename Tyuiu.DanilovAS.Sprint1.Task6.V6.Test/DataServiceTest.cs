using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DanilovAS.Sprint1.Task6.V6.Lib;

namespace Tyuiu.DanilovAS.Sprint1.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            string value = "Hello World";
            string wait = "ello orld";
            var res = ds.DeleteFirstLetter(value);
            Assert.AreEqual(wait, res);
        }
    }
}
