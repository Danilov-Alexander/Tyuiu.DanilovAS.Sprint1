using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DanilovAS.Sprint1.Task3.V8.Lib;

namespace Tyuiu.DanilovAS.Sprint1.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double timeDays = 30; // Срок вклада
            double percent = 20; // Проц.Ставка
            double wait = 2541.10; // Переменная, которую мы ожидаем получить в методе AreEqual
            var res = Math.Round(ds.IncomeAmount(percent,timeDays),2);
            Assert.AreEqual(wait, res);
        }
    }
}
