using System;
using System.Collections.Generic;
using Tax.Calculator.Domain.Entities.Reference;
using Tax.Calculator.Domain.Reference.Entities;

namespace Tax.Calculator.Domain.Entities.Transactional
{
    public class TaxCalculation
    {
        public int Code { get; private set; }

        public int StrategyCode { get; private set; }

        public int TypeCode { get; private set; }

        public int Level { get; private set; }

        public decimal MinimumAmount { get; private set; }

        public decimal? MaximumAmount { get; private set; }

        public int ValueCode { get; private set; }

        public decimal Value { get; private set; }

        public TaxCalculationType TaxCalculationType { get; private set; }

        public TaxCalculationStrategy TaxCalculationStrategy { get; set; }

        public TaxValue TaxValue { get; private set; }
    }
}
