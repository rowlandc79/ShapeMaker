using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrawingLibrary;

namespace ShapeTester
{
    [TestClass]
    public class UnitTests
    {

        [TestMethod]
        public void TestBasicShape_Rectangle()
        {
            Widget widget = new Rectangle(10,10,30,40);

            Assert.AreEqual("Rectangle (10,10) width=30 height=40",widget.Print());
        }

        [TestMethod]
        public void TestBasicShape_Square()
        {
            Widget widget = new Square(15, 30, 35);

            Assert.AreEqual("Square (15,30) size=35", widget.Print());
        }

    }
}
