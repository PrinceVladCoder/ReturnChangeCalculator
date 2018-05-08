using System;

namespace ChangeReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the cost of the item ");
            double itemPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How much did you pay with?");
            double moneyGiven = Convert.ToDouble(Console.ReadLine());

            int change = Convert.ToInt32(moneyGiven - itemPrice);
            Console.WriteLine(" Your change is R " + change);

            int twentyRand = 20;
            int tenRand = 10;
            int fiveRand = 5;
            int twoRand = 2;
            int oneRand = 1;

            int twentyRands = change / twentyRand;
            int tenRands = (change % twentyRand)/10;
            int fiveRands = (change - (twentyRands*20) - (tenRands*10)) / 5;
            int twoRands = (change - (twentyRands * 20) - (tenRands * 10) - (fiveRands * 5)) / 2;
            int oneRands = (change - (twentyRands * 20) - (tenRands * 10) - (fiveRands * 5) - (twoRands * 2)) / 1;

            Console.WriteLine("Your change will be " + twentyRands + " twenty rands, " + tenRands + " ten rands " + fiveRands + " five rands " + twoRands + " two rands and " + oneRands + " one rands"); // + "20 rands" + tenRand + "10 rands" + fiveRands + "5 rands");
        }
    }
}
