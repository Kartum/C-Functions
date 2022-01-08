using System;

namespace simpleCalculatorInCS.calculation
{
    public class Round : Calculation
    {
        public override int getId()
        {
            return 10;
        }
        
        public override string getPrettyName()
        {
            return "Yuvarlama";
        }
        
        public override bool needsTwoNumber()
        {
            return false;
        }
        
        public override double calculate(double number)
        {
            return Math.Round(number);
        }
    }
}