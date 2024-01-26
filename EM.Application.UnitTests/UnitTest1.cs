using NUnit.Framework.Internal;

namespace EM.Application.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int actual = 20;
            Assert.AreEqual(20, actual);
        }
    }
}