using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SozonovAD.Sprint1.Task2.V26.Lib;

namespace Tyuiu.SozonovAD.Sprint1.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 30;
            var res = ds.CalculateMinutesSinceStart(x,y);
            Assert.AreEqual(150, res);
        }
    }
}
