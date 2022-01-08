namespace simpleCalculatorInCS.calculation
{
    public abstract class Calculation
    {
        public virtual double calculate(double number1, double number2)
        {
            return 0;
        }
        
        public virtual double calculate(double number)
        {
            return 0;
        }

        public virtual string getPrettyName()
        {
            return "";
        }
        
        public virtual int getId()
        {
            return 0;
        }
        
        public virtual bool needsTwoNumber()
        {
            return true;
        }
    }
}