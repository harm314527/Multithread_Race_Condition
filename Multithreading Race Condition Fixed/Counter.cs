using System;
using System.Collections.Generic;
using System.Text;

namespace Multithreading_Race_Condition_Fixed
{
    class Counter
    {
        public int Value { get; set; }
        public Counter(int value)
        {
            Value = value;
        }
        
        
        public void CountUp()
        {
          Value++;
        }
        public void Countdown()
        {
          Value--;
        }
    }
}
