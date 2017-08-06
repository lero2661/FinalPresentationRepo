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
    }
}
