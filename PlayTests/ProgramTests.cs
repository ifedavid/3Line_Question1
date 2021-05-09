using Microsoft.VisualStudio.TestTools.UnitTesting;
using Play;
using System;
using System.Collections.Generic;
using System.Text;

namespace Play.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void DifferentNumberTest1()
        {
            Question1 myProgram = new Question1();
            int solution = myProgram.DifferentNumber(new int[] { -1, 2, 3, 4 });
            Assert.AreEqual(1, solution);
        }
    }
}