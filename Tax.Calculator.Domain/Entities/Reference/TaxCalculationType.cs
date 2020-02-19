using System;
using System.Collections.Generic;
using Tax.Calculator.Domain.Entities.Transactional;

namespace Tax.Calculator.Domain.Reference.Entities
{
    public class TaxCalculationType
    {
        public int Code { get; private set; }

        public string Type { get; private set; }

        public string Description { get; private set; }

        public HashSet<TaxCalculation> TaxCalculations { get; set; }
    }
}
