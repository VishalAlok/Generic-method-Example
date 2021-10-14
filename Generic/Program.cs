using System;

namespace Generic
{

    class Program
    {
        //Generic Method
        public static bool EqualCheck<G>(G a, G b)
        {
            bool c = a.Equals(b);
            return c; 
        }

        static void Main(string[] args)
        {
            bool result1 = EqualCheck(10, 10);
            bool result2 = EqualCheck(10, 10);
            bool result3 = EqualCheck("Vishal", "Vishal");
            bool result4 = EqualCheck<string>("Vishal", "Vishal");
            bool result5 = EqualCheck('V', 'V');
            bool result6 = EqualCheck<char>('V', 'V');
            Console.WriteLine(result1.ToString() +  result2.ToString() +  result3.ToString());
            Console.WriteLine(result4.ToString() + result5.ToString() + result6.ToString());
        }
    }
}
