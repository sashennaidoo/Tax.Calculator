using System;
namespace Tax.Calculator.Domain.Contracts.Providers
{
    public interface ITaxCalculationProvider
    {
        decimal Calculate(decimal salary);
    }
}
