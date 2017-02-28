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
            Widget widget = new Widget("rectangle",10,10,30,40);

            Assert.AreEqual("Rectangle (10,10) width=30 height=40",widget.Print());
        }

        [TestMethod]
        public void TestBasicShape_Square()
        {
            Widget widget = new Widget("square", 15, 30, 35, 0);

            Assert.AreEqual("Square (10,10) size = 35", widget.Print());
        }

    }
}
