using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ModenovaAP.Sprint1.Review.V22.Lib;

namespace Tyuiu.ModenovaAP.Sprint1.Review.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 1;
            double wait = 1.113;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
