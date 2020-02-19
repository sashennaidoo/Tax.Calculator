using System;
using Tax.Calculator.Domain.Reference.Entities;

namespace Tax.Calculator.Domain.Entities.Transactional
{
    public class PostalCodeTax
    {
        public int Code { get; private set; }

        public string PostalCode { get; private set; }

        public int TaxTypeCode { get; private set; }

        public TaxCalculationType TaxCalculationType { get; private set; }
    }
}
