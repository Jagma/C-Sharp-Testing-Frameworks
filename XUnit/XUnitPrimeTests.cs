using Prime.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnit_Testing
{
    public class XUnitPrimeTests
    {
        /*
         * dependencies:
         * xunit.runner.visualstudio
         * xunit
         * Microsoft.NET.Test.Sdk
         */
        PrimeService _primeService;

        public XUnitPrimeTests()
        {
            _primeService = new PrimeService();
        }

        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            bool result = _primeService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }

        [Fact]
        public void IsPrime_InputIs3_ReturnTrue()
        {
            var result = _primeService.IsPrime(3);

            Assert.True(result, "3 should be prime");
        }
    }
}
