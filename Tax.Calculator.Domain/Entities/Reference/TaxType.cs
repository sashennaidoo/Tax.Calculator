using System;
using System.Collections.Generic;
using Tax.Calculator.Domain.Entities.Transactional;

namespace Tax.Calculator.Domain.Entities.Reference
{
    public class TaxType
    {
        public int Code { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public List<PostalCodeTax> PostalCodes { get; private set; }
    }
}
