﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblem
{
    internal class LengthOfaLine
    {
        public static void CalculateLength()
        {
            int x1, x2, y1, y2 = 0;
            Console.Write("Input an integer value: +x1 +x2 +y1 +y2 ");
            x1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            double distance;
            distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("distance =" + distance);
        }
    }
}
