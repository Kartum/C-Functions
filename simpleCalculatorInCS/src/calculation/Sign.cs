using System;

namespace simpleCalculatorInCS.calculation
{
    public class Sign : Calculation
    {
        public override int getId()
        {
            return 7;
        }
        
        public override string getPrettyName()
        {
            return "İşaretini Bulma";
        }
        
        public override bool needsTwoNumber()
        {
            return false;
        }
        
        public override double calculate(double number)
        {
            return Math.Sign(number);
        }
    }
}