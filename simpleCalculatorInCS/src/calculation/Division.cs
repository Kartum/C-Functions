namespace simpleCalculatorInCS.calculation
{
    public class Division : Calculation
    {
        public override int getId()
        {
            return 4;
        }
        
        public override string getPrettyName()
        {
            return "Bölme";
        }
        
        public override bool needsTwoNumber()
        {
            return true;
        }
        
        public override double calculate(double number1, double number2)
        {
            return number1 / number2;
        }
    }
}