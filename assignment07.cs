using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HimanshuAssignments
{
    class assignment07
    {
        static void Main(string[] args)
        {
            bool process = true;
            do {
                int num = UIconsole.GetInt("Enter number");
                string result = isPrimeNumber(num) ? "Prime number" : "Not prime";
                Console.WriteLine(result);
                Console.WriteLine("Press any other key to clear screen");
                Console.ReadKey();
                Console.Clear();

            } while (process);

            

        }
        static Boolean isPrimeNumber(int num)
        {
            for(int i = 2; i < num / 2; i++)
            {
                if ((num % i) == 0)
                    return false;
            }
            return true;
        }
    }
}
