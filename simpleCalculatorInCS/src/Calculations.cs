using System;
using System.Collections.Generic;
using System.Linq;
using simpleCalculatorInCS.calculation;

namespace simpleCalculatorInCS
{
    public static class Calculations
    {
        private static List<Calculation> calculations = new List<Calculation>();
        
        public static void init()
        {
            foreach (var calculationType in Enum.GetValues(typeof(CalculationType)).Cast<CalculationType>())
            {
                Type myClass = Type.GetType("simpleCalculatorInCS.calculation." + calculationType);
                if (myClass != null)
                {
                    Calculation c = (Calculation) Activator.CreateInstance(myClass);
                    calculations.Add(c);
                }
                else
                {
                    throw new Exception("Calculation " + calculationType + " not found.");
                }
            }
        }

        public static List<Calculation> getAll()
        {
            return calculations;
        }

        public static Calculation getById(int id)
        {
            foreach (var calculation in calculations)
            {
                if (calculation.getId() == id)
                {
                    return calculation;
                }
            }

            return null;
        }
    }
}