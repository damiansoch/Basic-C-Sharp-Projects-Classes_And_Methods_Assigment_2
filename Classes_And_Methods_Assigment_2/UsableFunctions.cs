using System;

namespace Classes_And_Methods_Assigment_2
{
    public class UsableFunctions
    {
        //the method very symiliar to Math.Pow() method, but if user won,t provide the second argument, it will be assigned to default 2 (second power)   
        public double Power(double baseNr, double power = 2)
        {
            double result = Math.Pow(baseNr, power);
            return result;
        }
    }
}
