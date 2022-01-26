using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace Shapes.Tests
{
    [TestClass]
    public class ShapesTests
    {
        [TestMethod]
        public void Circle_Radius_5()
        {
            var actual = Math.Round(new Circle(5).Square, 4);
            Assert.AreEqual(78.5398, actual);
        }

        [TestMethod]
        public void Circle_Radius_13()
        {
            var actual = Math.Round(new Circle(13).Square, 4);
            Assert.AreEqual(530.9292, actual);
        }

        [TestMethod]
        public void Triangle_Edges_4_5_6()
        {
            var actual = Math.Round(new Triangle(4, 5, 6).Square, 4);
            Assert.AreEqual(9.9216, actual);
        }

        [TestMethod]
        public void Triangle_Edges_1_4_5_NotExist()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 4, 5));
        }

        [TestMethod]
        public void Triangle_Edges_3_4_5_IsRectangle()
        {
            Assert.IsTrue(new Triangle(3, 4, 5).IsRectangle);
        }
    }
}