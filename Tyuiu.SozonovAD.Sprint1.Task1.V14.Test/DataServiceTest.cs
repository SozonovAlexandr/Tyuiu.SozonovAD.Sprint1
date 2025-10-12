using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SozonovAD.Sprint1.Task1.V14.Lib;

namespace Tyuiu.SozonovAD.Sprint1.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 1.0;
            double b = 3.0;
            double c = 2.0;
            var res = ds.Calculate(a,b, c);
            Assert.AreEqual(1.7,res);
        }
    }
}
