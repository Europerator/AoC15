namespace UT_01
{
    [TestClass]
    public class TestFloor
    {
        [TestMethod]
        public void testOpenParenthese() { Assert.AreEqual(3, AoC15_01.Program.floor("(((")); }
        [TestMethod]
        public void testClosedParenthese() { Assert.AreEqual(-2, AoC15_01.Program.floor("))")); }
        [TestMethod]
        public void testBothParentheses() { Assert.AreEqual(0, AoC15_01.Program.floor("(())")); }
        [TestMethod]
        public void testMixedParentheses() { Assert.AreEqual(0, AoC15_01.Program.floor("()()"));  }
        [TestMethod]
        public void testMoreOpenParentheses() { Assert.AreEqual(3, AoC15_01.Program.floor("(()(()(")); }
        [TestMethod]
        public void testMoreClosedParentheses() { Assert.AreEqual(-2, AoC15_01.Program.floor("())())")); }
    }
    [TestClass]
    public class TestFirstToBasement
    {
        [TestMethod]
        public void testNeverToBasement() { Assert.AreEqual(0, AoC15_01.Program.firstToBasement("((((()())")); }
        [TestMethod]
        public void testOnceToBasement() { Assert.AreEqual(3, AoC15_01.Program.firstToBasement("())")); }
        [TestMethod]
        public void testTwiceToBasement() { Assert.AreEqual(5, AoC15_01.Program.firstToBasement("()())(())")); }
    }
}