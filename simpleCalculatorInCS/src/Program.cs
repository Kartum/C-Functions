using System;
using simpleCalculatorInCS.calculation;

namespace simpleCalculatorInCS
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calculations.init();
            
            Console.WriteLine("Merhaba! Lütfen yapacağınız işlemin numarasını giriniz: ");
            foreach (var cal in Calculations.getAll())
            {
                Console.WriteLine(cal.getId() + " - " + cal.getPrettyName());
            }
            Console.WriteLine("");
            
            string stringId = Console.ReadLine();
            int id;
            
            try
            {
                id = Int32.Parse(stringId);
            }
            catch (Exception e)
            {
                Console.WriteLine("Hatalı işlem numarası girildi.");
                return;
            }

            Calculation calculation = Calculations.getById(id);
            if (calculation != null)
            {
                Console.WriteLine("Seçilen işlem: " + calculation.getPrettyName());
                Console.WriteLine("Lütfen birinci sayıyı giriniz: ");
                string number1Str = Console.ReadLine();
                
                double number1;

                try
                {
                    number1 = Double.Parse(number1Str);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Girilen değer bir sayı olmalıdır.");
                    return;
                }

                Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
                string number2Str = Console.ReadLine();

                double number2;
                
                try
                {
                    number2 = Double.Parse(number2Str);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Girilen değer bir sayı olmalıdır.");
                    return;
                }
                
                Console.WriteLine("");
                Console.WriteLine("İşlemin sonucu: " + calculation.calculate(number1, number2));
            }
            else
            {
                Console.WriteLine("Seçilen işlem bulunamadı.");
            }
        }
    }
}