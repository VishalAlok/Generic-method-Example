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
            bool result1= EqualCheck(10,10);
            bool result2 = EqualCheck("Vishal", "Vishal");
            bool result3 = EqualCheck('V', 'V');
            Console.WriteLine(result1.ToString() +  result2.ToString() +  result3.ToString());
        }
    }
}
