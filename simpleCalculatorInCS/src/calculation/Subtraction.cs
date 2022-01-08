namespace simpleCalculatorInCS.calculation
{
    public class Subtraction : Calculation
    {
        public override int getId()
        {
            return 2;
        }
        
        public override string getPrettyName()
        {
            return "Çıkarma";
        }
        
        public override bool needsTwoNumber()
        {
            return true;
        }
        
        public override double calculate(double number1, double number2)
        {
            return number1 - number2;
        }
    }
}