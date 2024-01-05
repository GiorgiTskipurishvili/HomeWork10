using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance
{
    public class MicroFinance : FinanceOperations
    {
        //CheckUserHistory არის ყოველთვის True 
        public bool CheckUserHistory()
        {
            return true;
        }

        /*CalculateLoanPercent() დააბრუნებს მაქსიმალურ გადასახდელ თანხას ამ შემთხვევაში 
         * საკომისიო არის 10% და ყოველთვიურად ემატება მომსახურეობის საკომისიო 4$ ოდენობით*/
        public double CalculateLoanPercent(int month, double AmountPerMonth)
        {
            double amountCommision = 0.1;
            double serviceFee = 4;

            double totalAmount = AmountPerMonth * month * (1 + amountCommision) + (serviceFee * month);
            Console.WriteLine($"MicroFInance's total amount loan to be paid: {totalAmount}");
            return totalAmount;


        }


    }
}
