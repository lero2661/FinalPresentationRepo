using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleDemoProject;

namespace SimpleDemoProject.Tests
{
    [TestClass]
    public class UnitTest1
    {
        Program program = new Program();
        [TestMethod]
        public void additionTest()
        {

            Assert.AreEqual(program.addition(1, 3), 4);
        }

        [TestMethod]
        public void additionTest2()
        {
            Assert.AreNotEqual(program.addition(1, 3), 5);
        }

        [TestMethod]
        public void subtractionTest()
        {

            Assert.AreEqual(program.subtraction(1, 3), 2);
        }

        [TestMethod]
        public void subtractionTest2()
        {

            Assert.AreEqual(program.subtraction(3, 1), 2);
        }

        [TestMethod]
        public void multiplicationTest()
        {

            Assert.AreEqual(program.multiplication(2, 3), 6);
        }

        [TestMethod]
        public void multiplicaitonTest2()
        {

            Assert.AreEqual(program.multiplication(3, 3), 9);
        }

        [TestMethod]
        public void powTest()
        {
            Assert.AreEqual(program.pow(3, 2), 9);
        }
    }
}
