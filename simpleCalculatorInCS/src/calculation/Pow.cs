using System;

namespace simpleCalculatorInCS.calculation
{
    public class Pow : Calculation
    {
        public override int getId()
        {
            return 5;
        }
        
        public override string getPrettyName()
        {
            return "Üs Alma";
        }
        
        public override bool needsTwoNumber()
        {
            return true;
        }
        
        public override double calculate(double number1, double number2)
        {
            return Math.Pow(number1, number2);
        }
    }
}