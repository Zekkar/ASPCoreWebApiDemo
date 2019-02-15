using ASPCoreWebAPI.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTestASPCoreWebApi.Model
{
    [TestClass]
    public class CaculateTests
    {
        
        private Caculate CreateCaculate()
        {
            return new Caculate();
        }

        [TestMethod]
        public void AddNum_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateCaculate();
            int a = 1;
            int b = 2;
            int expected = 3;
            int actual;

            // Act
            actual = unitUnderTest.AddNum(a, b);


            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void LessNum_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateCaculate();
            int a = 1;
            int b = 2;
            int expected = 1;
            int actual;

            // Act
            actual = unitUnderTest.LessNum(b,a);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
