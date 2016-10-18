using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitterKata
{
    public class CompensationCalculator
    {   
        //this is a reasonable bedtime
        int bedtime = 9;

        public CompensationCalculator()
        {
        }

        public decimal calc(int start, int end)
        {
            decimal compensation = (end - start) * 12;
            return compensation;
        }
    }
}
