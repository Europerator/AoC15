using AoC_15_02;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AoC15_02.UnitTest
{
    [TestClass]
    public class BoxTest
    {
        [TestMethod]
        public void testParseStringNoEndLine()
        {
            Box testObject = new Box("3x2x1");
            Assert.AreEqual(3, testObject.getLength());
            Assert.AreEqual(2, testObject.getWidth());
            Assert.AreEqual(1, testObject.getHeight());
        }
        [TestMethod]
        public void testParseStringWithEndLine()
        {
            Box testObject = new Box("3x2x1\n");
            Assert.AreEqual(3, testObject.getLength());
            Assert.AreEqual(2, testObject.getWidth());
            Assert.AreEqual(1, testObject.getHeight());
        }
        [TestMethod]
        public void testSmallestAreaFromListSideAreas()
        {
            Box testObject = new Box(4, 5, 6);
            Assert.AreEqual(20, testObject.listSideAreas().Min());
        }
        [TestMethod]
        public void testRequiredAreaTheBoxIsADot()
        {
            Box testObject = new Box(0, 0, 0);
            Assert.AreEqual(0, testObject.requiredArea());
        }
        [TestMethod]
        public void testRequiredAreaTheBoxIsAPlane()
        {
            Box testObject = new Box(0, 2, 3);
            Assert.AreEqual(12, testObject.requiredArea());
        }
        [TestMethod]
        public void testRequiredAreaTheBoxIsARectangularPrism()
        {
            Box testObject = new Box(3, 5, 4);
            Assert.AreEqual(106, testObject.requiredArea());
        }
    }
}