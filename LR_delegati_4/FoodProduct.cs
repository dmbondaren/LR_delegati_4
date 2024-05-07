using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_delegati_4
{
    public class FoodProduct
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public double Calories { get; set; }
        public CalculateUsefulness UsefulnessDelegate { get; set; }
    }
}
