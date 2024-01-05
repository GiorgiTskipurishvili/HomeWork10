using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance
{
    public class Bank : FinanceOperations
    {


        //Bank-ს შემთხვევაში CheckUserHistory აბრუნებს რენდომად ან true ან false,
        public bool CheckUserHistory()
        {
            Random random = new Random();
            bool randomBoolean = random.Next(2) == 0;
            Console.WriteLine($"random boolean:{randomBoolean}");
            return randomBoolean;
        }


        public double CalculateLoanPercent(int month, double AmountPerMonth)
        {
            double percentageRate = 0.05;

            double totalAmount = AmountPerMonth * month * (1 + percentageRate);
            Console.WriteLine($"Bank's total amount loan to be paid: {totalAmount}");

            return totalAmount;
        }

    }
}
