using System;

namespace Classes_And_Methods_Assigment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultOne = UsableFunctions.Power(5, 3);
            double resultTwo = UsableFunctions.Power(-3, 1);
            double resultThree = UsableFunctions.Power(14);

            Console.WriteLine("base:5, power:3 = " + resultOne + "\n base:-3, power:1 = " + resultTwo + "\n base:14, power: 2(default) =" + resultThree);
            Console.ReadLine();
        }
    }
}
