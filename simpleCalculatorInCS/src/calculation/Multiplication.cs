namespace simpleCalculatorInCS.calculation
{
    public class Multiplication : Calculation
    {
        public override int getId()
        {
            return 3;
        }
        
        public override string getPrettyName()
        {
            return "Çarpma";
        }
        
        public override bool needsTwoNumber()
        {
            return true;
        }
        
        public override double calculate(double number1, double number2)
        {
            return number1 * number2;
        }
    }
}