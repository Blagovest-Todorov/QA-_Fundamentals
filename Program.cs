using System;

namespace TestCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter Your age in whole numbers from 0 till 150 only");

            Console.WriteLine();

            var s = Console.ReadLine();

            
            if (TestForNullOrEmpty(s))
            {
                Console.WriteLine(
                    "{0} no value entered or white space, enter int value", s);
                return;
            }

            bool trueAge = int.TryParse(s, out int age);

            if (trueAge == false)
            {
                Console.WriteLine("Please enter a valid integer value");
                return;
            }

            if (age <= 0)    ///missing a boundary value <= 0,  on second step was corrected
            {
                Console.WriteLine("age is less than or equal zero");
            }
            else if (age > 0 && age < 18)
            {
                Console.WriteLine("your age is of Teenager");
            }
            else if (age >= 18 && age <= 150)
            {
                Console.WriteLine("yoyur age is of Teenager");
            }

        }

        static bool TestForNullOrEmpty(string s)
        {
            bool result;
            result = s == null || s == string.Empty;
            return result;
        }
    }
}
