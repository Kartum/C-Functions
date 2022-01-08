using System;
using System.Threading;
using simpleCalculatorInCS.calculation;

namespace simpleCalculatorInCS
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calculations.init();
            startProgram();
        }
        
        private static void startProgram()
        {
            try
            {
                Console.WriteLine("Merhaba! Lütfen yapacağınız işlemin numarasını giriniz: ");
                foreach (var cal in Calculations.getAll())
                {
                    Console.WriteLine(cal.getId() + " - " + cal.getPrettyName());
                }
                Console.WriteLine("");
            
                int id = Int32.Parse(Console.ReadLine());

                Calculation calculation = Calculations.getById(id);
                if (calculation != null)
                {
                    Console.WriteLine("Seçilen işlem: " + calculation.getPrettyName());

                    if (calculation.needsTwoNumber())
                    {
                        Console.WriteLine("Lütfen birinci sayıyı giriniz: ");
                        double number1 = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
                        double number2 = Double.Parse(Console.ReadLine());
                
                        Console.WriteLine("");
                        Console.WriteLine("Sonuç: " + calculation.calculate(number1, number2));
                    }
                    else
                    {
                        Console.WriteLine("Lütfen sayıyı giriniz: ");
                        double number = Double.Parse(Console.ReadLine());
                    
                        Console.WriteLine("");
                        Console.WriteLine("Sonuç: " + calculation.calculate(number));
                    }
                    
                    Thread.Sleep(3000);
                    startProgram();
                }
                else
                {
                    throw new Exception("Seçilen işlem bulunamadı.");
                }
            }
            catch (Exception exception)
            {
                String message = exception.Message;
                
                if (exception.GetType() == typeof(FormatException))
                {
                    message = "Girilen değer bir sayı olmalıdır.";
                }
                
                Console.WriteLine("Hata: " + message);
                Thread.Sleep(3000);
                startProgram();
            }
        }
    }
}