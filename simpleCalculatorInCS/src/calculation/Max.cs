using System;

namespace simpleCalculatorInCS.calculation
{
    public class Max : Calculation
    {
        public override int getId()
        {
            return 8;
        }
        
        public override string getPrettyName()
        {
            return "Büyük Sayıyı Bulma";
        }
        
        public override bool needsTwoNumber()
        {
            return true;
        }
        
        public override double calculate(double number1, double number2)
        {
            return Math.Max(number1, number2);
        }
    }
}