using System;

namespace simpleCalculatorInCS
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Merhaba! Lütfen yapacağınız işlemi seçin: ");
            Console.WriteLine("- toplama");
            Console.WriteLine("");
            string islem = Console.ReadLine();
            Console.WriteLine("Seçilen işlem: " + islem);
        }
    }
}