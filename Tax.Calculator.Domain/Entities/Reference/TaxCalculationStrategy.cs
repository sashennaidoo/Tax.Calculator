﻿using System;
using System.Collections.Generic;
using Tax.Calculator.Domain.Entities.Transactional;

namespace Tax.Calculator.Domain.Entities.Reference
{
    public class TaxCalculationStrategy
    {

        public int Code { get; private set; }

        public string Value { get; private set; }

        public string Description { get; private set; }

        public HashSet<TaxCalculation> TaxCalculation { get; set; }
    }
}
