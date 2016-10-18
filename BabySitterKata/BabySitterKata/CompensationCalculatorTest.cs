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
            Assert.AreEqual(12m, Compensation.calc(start, end));
        }
        [TestMethod()]
        public void WhenBabySitterStaysTillBedtime()
        {
            CompensationCalculator Compensation = new CompensationCalculator();
            int start = 5;
            int end = 9;
            //making bedtime 9 pm because that's a reasonable time a child should
            // go to bed
            Assert.AreEqual(48m, Compensation.calc(start, end));
        }
    }
}
