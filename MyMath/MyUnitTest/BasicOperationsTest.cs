using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyPrograms;


namespace MyUnitTest
{
    [TestClass]
    public class BasicOperationsTest
    {
        [TestMethod]
        public void TestAdd()
        {
            BasicOperations basicOperations = new BasicOperations();
            int actualResult = basicOperations.Add(2,3);
            int expectedResult = 5;
            Assert.AreEqual(expectedResult,actualResult);

        }


        [TestMethod]
        public void TestMul()
        {
            BasicOperations basicOperations = new BasicOperations();
            int expectedResult = 6;
            int actualResult = basicOperations.Mul(2, 3);
         
            Assert.AreEqual(expectedResult,actualResult);

        }
    }
}
