using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance
{
    /*•	შექმენით ინტერფეისი  FinanceOperations რომელსაც ექნება 2 მეთოდი 
    CalculateLoanPercent(int month, double AmountPerMonth), CheckUserHistory()  
    */
    public interface FinanceOperations
    {
        double CalculateLoanPercent(int month, double AmountPerMonth);
        bool CheckUserHistory();
    }
}
