using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_delegati_4
{
    public class UsefulnessCalculator
    {
        public static double Method1(double calories) => calories * 2;
        public static double Method2(double calories) => calories * 0.5;
        public static double Method3(double calories) => calories * 1.5;
    }
}
