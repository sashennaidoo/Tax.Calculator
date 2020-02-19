using System;
using System.Collections.Generic;
using System.Linq;
using Tax.Calculator.Domain.Contracts.Providers;

namespace Tax.Calculator.Service.Providers
{
    public class ProgressiveTaxCalculationProvider : ITaxCalculationProvider
    {
        private List<Tuple<decimal, decimal?, decimal, int>> _salaryBrackets => new List<Tuple<decimal, decimal?, decimal, int>>
        {
            new Tuple<decimal, decimal?, decimal, int>(372950.00m, null, 0.35m, 6),
            new Tuple<decimal, decimal?, decimal, int>(171551.00m, 372950m, 0.33m, 5),
            new Tuple<decimal, decimal?, decimal, int>(82250.00m, 171551.00m, 0.28m, 4),
            new Tuple<decimal, decimal?, decimal, int>(33950.00m, 82250.00m, 0.25m, 3),
            new Tuple<decimal, decimal?, decimal, int>(8351.00m, 33950.00m, 0.15m, 2),
            new Tuple<decimal, decimal?, decimal, int>(0.00m, 8351.00m, 0.10m, 1),

        };

        // This is sound logic - Two thumbs up
        public decimal Calculate(decimal salary)
        {
            var tax = 0m;
            
            foreach(var val in _salaryBrackets.OrderByDescending(tuple => tuple.Item4))
            {
                if (salary > val.Item1)
                {
                    tax += val.Item3 * (salary - val.Item1);
                    salary = val.Item1;
                }  
            }
            return tax;
        }

        public ProgressiveTaxCalculationProvider()
        {
        }
    }
}
