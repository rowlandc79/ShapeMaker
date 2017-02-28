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

        [TestMethod]
        public void TestBasicShape_Ellipse()
        {
            Widget widget = new Ellipse(100,150,300,200);
            Assert.AreEqual("Ellipse (100,150) diameterH=300 diameterV=200", widget.Print());
        }

        [TestMethod]
        public void TestBasicShape_Circle()
        {
            Widget widget = new Circle(1, 1, 300);
            Assert.AreEqual("Circle (1,1) size=300", widget.Print());
        }

        [TestMethod]
        public void TestBasicShape_Textbox()
        {
            Widget widget = new Textbox(5, 5, 200, 100, "sample text");
            Assert.AreEqual("Textbox (5,5) width=200 height=100 Text=\"sample text\"", widget.Print());
        }

    }
}
