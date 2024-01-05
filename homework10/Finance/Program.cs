using System;

namespace Finance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FinanceOperations bank = new Bank();
            //Console.WriteLine("Please enter month");
            //int month = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter amount per month");
            //int amountPerMonth = Convert.ToInt32(Console.ReadLine());

            if (bank.CheckUserHistory())
            {
                double loanAmount = bank.CalculateLoanPercent(1, 1000);
            }
            else
            {
                Console.WriteLine("Loan rejected by Bank.");
            }



            FinanceOperations microFinance = new MicroFinance();
            if (microFinance.CheckUserHistory())
            {
                double loanAmount = microFinance.CalculateLoanPercent(1, 1000); 
            }
            else
            {
                Console.WriteLine("Loan rejected by MicroFinance.");
            }


        }
    }
}
