﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo
{
    internal class Calculator
    {
        public static Func<int, int, int> Add = (a, b) => a + b;
        public static Func<int, int, int> Multiply = (a, b) => a * b;
        public static Func<int, int, int> Subtract = (a, b) => a - b;
        public static Func<int, int, int> Divide = (a, b) => a / b;
    }
}
