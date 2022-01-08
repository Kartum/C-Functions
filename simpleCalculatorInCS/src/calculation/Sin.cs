using System;

namespace simpleCalculatorInCS.calculation
{
    public class Sin : Calculation
    {
        public override int getId()
        {
            return 11;
        }
        
        public override string getPrettyName()
        {
            return "Sinüs Bulma";
        }
        
        public override bool needsTwoNumber()
        {
            return false;
        }
        
        public override double calculate(double number)
        {
            return Math.Sin(number);
        }
    }
}