using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HimanshuAssignments
{
    class assignment03_calculator
    {
        static void Main(string[] args)
        {
            string menu="Press 1 for addition\n" + "Press 2 for subtraction\n" + "Press 3 for multiplication\n" + "Press 4 for division\n" + "Press 5 for square\n" + "Press 6 for square root\n";
            bool cycle = true;
            do 
            {             
                int choice = UIconsole.GetInt(menu);
                cycle = procesMenu(choice);
                Console.WriteLine("Press any other key to clear screen");
                Console.ReadKey();
                Console.Clear();
            } 
            while (cycle) ;
        }
        private static bool procesMenu(int choice)
        {
            switch (choice)

            {
                case 1: add(); return true;
                case 2:subtract(); return true;
                case 3:multiply(); return true;
                case 4:divide(); return true;
                case 5:square(); return true;
                case 6:squarert(); return true;
                default:
                    return false;
            }
        }
        private static void add()
        {
            double value1 = UIconsole.GetDouble("Enter 1st value");
            double value2 = UIconsole.GetDouble("Enter 2nd value");
            Console.WriteLine(value1 + value2); 

        }
        private static void subtract()
        {
           double value1 = UIconsole.GetDouble("Enter 1st value");
           double value2 = UIconsole.GetDouble("Enter 2nd value");
            Console.WriteLine(value1 - value2);
        }
        private static void multiply()
        {
            double value1 = UIconsole.GetDouble("Enter 1st value");
            double value2 = UIconsole.GetDouble("Enter 2nd value");
            Console.WriteLine(value1 * value2);
        }
        private static void divide()
        {
            double value1 = UIconsole.GetDouble("Enter 1st value");
            double value2 = UIconsole.GetDouble("Enter 2nd value");
            Console.WriteLine(value1 / value2); 
        }
        private static void square()
        {
            double value1 = UIconsole.GetDouble("Enter 1st value");
            Console.WriteLine("value1 * value1"); 
        }
        private static void squarert()
        {
            double value1 = UIconsole.GetDouble("Enter 1st value");
            Console.WriteLine(Math.Sqrt(value1)); 
        }
    }
}
