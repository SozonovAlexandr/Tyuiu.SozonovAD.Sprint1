using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SozonovAD.Sprint1.Task4.V6.Lib;


namespace Tyuiu.SozonovAD.Sprint1.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 5;
            double wait = 2.3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
