namespace simpleCalculatorInCS.calculation
{
    public class Addition : Calculation
    {
        public override int getId()
        {
            return 1;
        }
        
        public override string getPrettyName()
        {
            return "Toplama";
        }
        
        public override double calculate(double number1, double number2)
        {
            return number1 + number2;
        }
    }
}