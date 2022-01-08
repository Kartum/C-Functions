using System;

namespace simpleCalculatorInCS.calculation
{
    public class Cos : Calculation
    {
        public override int getId()
        {
            return 12;
        }
        
        public override string getPrettyName()
        {
            return "Kosinüs Bulma Bulma";
        }
        
        public override bool needsTwoNumber()
        {
            return false;
        }
        
        public override double calculate(double number)
        {
            return Math.Cos(number);
        }
    }
}