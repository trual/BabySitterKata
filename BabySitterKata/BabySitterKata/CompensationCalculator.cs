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
            decimal compensation = 0.0m;
            //need to set bounds for the times
            //start >= 5 or < 4
            //from bedtime to midnight rate is 8/hr
            
            //start after bedtime
            if (start >= bedtime)
            {
                if (end < start)
                {
                    compensation = (12 - start) * 8;
                    compensation += end * 16;
                }
                else
                {
                    compensation = (end - start) * 8;
                }
            }
            else if (end < start && start < bedtime)
            {
                compensation = (bedtime - start) * 12;
                compensation += (12 - bedtime) * 8;
                compensation += end * 16;
            }
            else if (end > bedtime && start < bedtime)
            {
                compensation = (bedtime - start) * 12;
                compensation += (end - bedtime) * 8;
            }
            else
            {
                compensation = (end - start) * 12;
            }
            
            return compensation;
        }
    }
}
