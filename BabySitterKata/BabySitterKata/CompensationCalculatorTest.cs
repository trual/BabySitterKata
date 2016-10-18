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

        
        CompensationCalculator Compensation = new CompensationCalculator();
        int start = 0;
        int end = 0;
        


        [TestMethod()]
        public void WhenCCIsPassedAStartTimeAndEndTime()
        {
            start = 5;
            end = 6;
            Assert.AreEqual(12m, Compensation.calc(start, end));
        }
        [TestMethod()]
        public void WhenBabySitterStaysTillBedtime()
        {
            start = 5;
            end = 9;
            //making bedtime 9 pm because that's a reasonable time a child should
            // go to bed
            Assert.AreEqual(48m, Compensation.calc(start, end));
        }
        [TestMethod()]
        public void WhenBabySitterStayTillMidnight()
        {
            start = 5;
            end = 12;
            Assert.AreEqual(72m, Compensation.calc(start, end));

        }
        [TestMethod()]
        public void WhenBabySitterStaysTillEndOfJob()
        {
            start = 5;
            end = 4;
            Assert.AreEqual(136m, Compensation.calc(start, end));
        }
    }
}
