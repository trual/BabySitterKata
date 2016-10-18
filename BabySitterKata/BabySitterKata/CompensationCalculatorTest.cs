using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitterKata
{
    [TestClass()]
    public class CompensationCalculatorTest
    {
        public CompensationCalculatorTest()
        {

        }

        [TestMethod()]
        public void WhenCCIsPassedAStartTimeAndEndTime()
        {
            CompensationCalculator Compensation = new CompensationCalculator();
            int start = 5;
            int end = 6;
            Assert.AreEqual(0.0m, Compensation.calc(start, end));
        }

    }
}
