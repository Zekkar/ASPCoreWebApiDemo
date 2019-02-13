using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASPCoreWebAPI.Model;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void AddNum_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = new Caculate();
            int a = 1;
            int b = 2;
            int expected = 3;
            int actual;

            // Act
            actual = unitUnderTest.AddNum(a, b);


            // Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
