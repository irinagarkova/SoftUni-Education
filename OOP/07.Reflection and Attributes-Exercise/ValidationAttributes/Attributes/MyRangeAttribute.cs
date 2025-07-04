using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationAttributes.Attributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        public MyRangeAttribute(int minValue, int maxValue)
        {
            this.MinValue = minValue;
            this.MaxValue = maxValue;
        }
        public int MinValue { get; }
        public int MaxValue { get; }


        public override bool IsValid(object obj)
            => obj is int num && this.MinValue <= num && num <= this.MaxValue;
    }
}
