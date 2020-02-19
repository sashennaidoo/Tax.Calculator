using System;
namespace Tax.Calculator.Domain.Entities.Transactional
{
    public class UserIncomeTax
    {
        public int Code { get; private set; }

        public string PostalCodeInput { get; private set; }

        public decimal AnnualIncome { get; private set; }

        public decimal IncomeTax { get; private set; }

        public DateTime Date { get; private set; }

    }
}
