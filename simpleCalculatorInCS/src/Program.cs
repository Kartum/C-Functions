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
            catch (Exception exception)
            {
                Console.WriteLine("Hatalı işlem numarası girildi.");
                return;
            }

            Calculation calculation = Calculations.getById(id);
            if (calculation != null)
            {
                Console.WriteLine("İşlem yapılacak.");
            }
            else
            {
                Console.WriteLine("Seçilen işlem bulunamadı.");
            }
        }
    }
}