using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom;
using Tyuiu.SozonovAD.Sprint1.Task3.V16.Lib;


namespace Tyuiu.SozonovAD.Sprint1.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 2;
            double x2 = 3;
            double b = -5;
            var res = ds.CoeffOfQuadraticEquation(x1, x2);
            Assert.AreEqual(b, res);
        }
    }
}
