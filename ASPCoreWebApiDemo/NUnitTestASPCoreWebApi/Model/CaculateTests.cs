using ASPCoreWebAPI.Model;
using Moq;
using NUnit.Framework;
using System;
using NUnit.Framework;

namespace NUnitTestASPCoreWebApi.Model
{
    [TestFixture]
    public class CaculateTests
    {
        private MockRepository mockRepository;



        [SetUp]
        public void SetUp()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        [TearDown]
        public void TearDown()
        {
            this.mockRepository.VerifyAll();
        }

        private Caculate CreateCaculate()
        {
            return new Caculate();
        }

        [Test]
        public void AddNum_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateCaculate();
            int a = 1;
            int b = 2;
            int expected = 3;
            int actual;

            // Act
            actual = unitUnderTest.AddNum(a,b);


            // Assert
            Assert.AreEqual(expected, actual);
            
        }

        //[Test]
        //public void LessNum_StateUnderTest_ExpectedBehavior()
        //{
        //    // Arrange
        //    var unitUnderTest = this.CreateCaculate();
        //    int a = 2;
        //    int b = 1;

        //    // Act
        //    var result = unitUnderTest.LessNum(
        //        a,
        //        b);

        //    // Assert
        //    Assert.Fail();
        //}
    }
}
