using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineBookstore.Models;

namespace OnlineBookstore.Tests.Controllers
{
    /// <summary>
    /// Summary description for MathsProblemsTests
    /// </summary>
    [TestClass]
    public class MathsProblemsTests
    {

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>

        [TestMethod]
        public void TestSumWithPositiveNumbers()
        {
            MathsProblems solver = new MathsProblems();
            int result = solver.Sum(2, 2);
            Assert.AreEqual(4, result, "This is wrong");
        }

        [TestMethod]
        public void TestSumWithOneNegativeNumber()
        {
            MathsProblems solver = new MathsProblems();
            int result = solver.Sum(-2, 3);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSumWithBigNumbers()
        {
            MathsProblems solver = new MathsProblems();
            int result = solver.Sum(200000000, 200000000);
        }
    }
}
