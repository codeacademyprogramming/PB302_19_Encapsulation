using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class Employee:Human
    {
        public override void SetAge(byte value)
        {
            if (value >= 25 && value <= 65)
                Age = value;
        }
    }
}
