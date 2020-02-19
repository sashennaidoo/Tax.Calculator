using System;

namespace Tax.Calculator.Domain
{
    public class RateCalculatorFactory
    {
        public IRateProvider GetRateProvider(RateType rateType)
        {
            switch (rateType)
            {
                case RateType.FlatRate:
                    return new FlatRateProvider();
                case RateType.Progressive:
                    return new ProgressiveRateProvider();
            }
        }
    }

    public interface IRateProvider
    {
        double CalculateTax(double incomeTax);
    }

    public enum RateType
    {
        Progressive,
        FlatRate,
        FlatValue
    }

    public class ProgressiveRateProvider : IRateProvider
    {
        public double CalculateTax(double incomeTax)
        {
            throw new NotImplementedException();
        }
    }

    public class FlatRateProvider : IRateProvider
    {
        public double CalculateTax(double incomeTax)
        {
            throw new NotImplementedException();
        }
    }
}

namespace Tax.Calculator.Domain.Caller
{
    public class CalculateRate
    {
        

         public void CalcRate()
         {
            // Enter post code and income
            var postalCode = "7441";

            //Go to database
            var taxType = (RateType)1;

            // Get the relevant rate calculator
            var rateCalculationProvider = new RateCalculatorFactory().GetRateProvider(taxType);

            // Calculat
         }
    }
}