using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SozonovAD.Sprint1.Task5.V3.Lib;

namespace Tyuiu.SozonovAD.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {

            DataService ds = new DataService();

            int k = 11111111;

            int wait = 6;
            int res = ds.Calculate(k);
            Assert.AreEqual(wait, res);
        }
    }
}
