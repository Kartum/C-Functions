using System;

namespace simpleCalculatorInCS.calculation
{
    public class Abs : Calculation
    {
        public override int getId()
        {
            return 6;
        }
        
        public override string getPrettyName()
        {
            return "Mutlak Değer Bulma";
        }
        
        public override bool needsTwoNumber()
        {
            return false;
        }
        
        public override double calculate(double number)
        {
            return Math.Abs(number);
        }
    }
}