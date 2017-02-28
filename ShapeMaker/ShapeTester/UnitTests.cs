using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrawingLibrary;

namespace ShapeTester
{
    [TestClass]
    public class UnitTests
    {

        [TestMethod]
        public void TestBasicShape_Square()
        {
            Widget widget = new Widget("Rectangle",10,10,30,40);

            Assert.AreEqual("Rectangle (10,10) width=30 height=40",widget.Print());
        }

    }
}
