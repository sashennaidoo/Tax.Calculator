using NUnit.Framework;
using Tax.Calculator.Service.Providers;

namespace Tax.Calculator.Test
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void Test()
        {
            var calculator = new ProgressiveTaxCalculationProviders();

            var tax = calculator.Calculate(10000000);
            
            Assert.AreEqual(tax, decimal.Parse("3477683.02"));
        }
    }
}