using System;

namespace simpleCalculatorInCS.calculation
{
    public class Min : Calculation
    {
        public override int getId()
        {
            return 9;
        }
        
        public override string getPrettyName()
        {
            return "Küçük Sayıyı Bulma";
        }
        
        public override bool needsTwoNumber()
        {
            return true;
        }
        
        public override double calculate(double number1, double number2)
        {
            return Math.Min(number1, number2);
        }
    }
}