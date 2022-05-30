using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowTests.SUT
{
    internal class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }
        public int Subtract()
        {
            return SecondNumber - FirstNumber;
        }
        public int Multiply()
        {
            return SecondNumber*FirstNumber;
        }

        public int Divide()
        {
            return  FirstNumber/SecondNumber;
        }

        public int DividedByZero()
        {
            if (FirstNumber == 0)
                return 0;
            else
                return SecondNumber/FirstNumber;
        }
    }
}
    

