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
        public void ContigousArray_Test()
        {
            Question1 myProgram = new Question1();
            int solution = myProgram.DifferentNumber(new int[] { -1, 2, 3, 4 });
            Assert.AreEqual(1, solution);
        }

        [TestMethod()]
        public void EmptyArray_Test()
        {
            Question1 myProgram = new Question1();
            int solution = myProgram.DifferentNumber(new int[] { });
            Assert.AreEqual(1, solution);
        }

        [TestMethod()]
        public void ArbituaryElements_Test()
        {
            Question1 myProgram = new Question1();
            int solution = myProgram.DifferentNumber(new int[] { 1, 24, 4, 3, 2, 65, 8 });
            Assert.AreEqual(5, solution);
        }


        [TestMethod()]
        public void NegativeElements_Test()
        {
            Question1 myProgram = new Question1();
            int solution = myProgram.DifferentNumber(new int[] { -1, -4, -23, -34 });
            Assert.AreEqual(1, solution);
        }
    }
}