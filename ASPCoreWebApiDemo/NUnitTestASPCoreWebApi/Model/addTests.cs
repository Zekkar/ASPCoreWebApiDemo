using ASPCoreWebAPI.Model;
using Moq;
using NUnit.Framework;
using System;

namespace NUnitTestASPCoreWebApi.Model
{
    [TestFixture]
    public class addTests
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

        private add Createadd()
        {
            return new add();
        }

        [Test]
        public void AddOne_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.Createadd();
            int a = 1;
            int b = 2;
            int result;
            int sum = 3;
            // Act
            result = unitUnderTest.AddOne(
                a,
                b);

            // Assert
            Assert.AreEqual(sum, result);
        }
    }
}
