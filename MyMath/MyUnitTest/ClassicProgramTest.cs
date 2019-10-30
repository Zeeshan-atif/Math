using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyPrograms;

namespace MyUnitTest
{

    [TestClass]
    public class ClassicProgramTest
    {
        
           [TestMethod]
                public void TestIsEven()
                {
            ClassicPrograms classicPrograms = new ClassicPrograms();
            bool expectedResult = true;
            bool actualResult = classicPrograms.IsEven(8);
            Assert.AreEqual(expectedResult, actualResult);
                }
        [TestMethod]
        public void TestIsNotEven()
        {
            ClassicPrograms classicPrograms = new ClassicPrograms();
            bool expectedResult = false;
            bool actualResult = classicPrograms.IsEven(7);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestNotPrime_withNegativeValue()
        {
            ClassicPrograms classicPrograms = new ClassicPrograms();
            bool expectedResult = false;
            bool actualResult = classicPrograms.IsPrime(-7);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestIsPrime_withTruePrimeValue()
        {
            ClassicPrograms classicPrograms = new ClassicPrograms();
            bool expectedResult = true;
            bool actualResult = classicPrograms.IsPrime(7);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestIsPrime_withFalsePrimeValue()
        {
            ClassicPrograms classicPrograms = new ClassicPrograms();
            bool expectedResult = false;
            bool actualResult = classicPrograms.IsPrime(-7);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
