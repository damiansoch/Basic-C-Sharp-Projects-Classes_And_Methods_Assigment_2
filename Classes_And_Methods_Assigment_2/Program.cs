using System;

namespace Classes_And_Methods_Assigment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            UsableFunctions usableFunctions = new UsableFunctions();


            Console.WriteLine("This program will count the Power of the number provided");
            Console.WriteLine("\n");

            Console.WriteLine("Please enter two numbers first number is the \"base\" and the second number is the \"power\". \n If the second number is not provided, The power will be 2 as a default. ");
            Console.WriteLine("Please enter \"base\". ");

            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you want to provide the power? If not, it will be the defoult - second power. \n Answer \"Y\" - Yes, \"N\" - No.");
            bool option = Console.ReadLine().ToLower() == "y" ? true : false;

            if (option)
            {
                Console.WriteLine("Please enter \"power\".");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                double resultOne = usableFunctions.Power(firstNumber, secondNumber);
                Console.WriteLine("base: " + firstNumber + ", power: " + secondNumber + " = " + resultOne);

            }
            else
            {
                double resultOne = usableFunctions.Power(firstNumber);
                Console.WriteLine("base: " + firstNumber + ", power: 2(default)" + " = " + resultOne);

            }





            Console.ReadLine();
        }
    }
}
