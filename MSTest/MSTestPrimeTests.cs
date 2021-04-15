#if MSTestBuild
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Category = Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute;
using Prime.Services;
#else
using NUnit.Framework;
using TestInitialize = NUnit.Framework.SetUpAttribute;
using TestContext = System.Object;
using TestProperty = NUnit.Framework.PropertyAttribute;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;
#endif

namespace MSTest
{
    [TestClass]
    public class MSTestPrimeTests
    {
        private PrimeService _primeService;

          /*
         * dependencies:
         * MSTest.TestFramework
         * MSTest.TestAdapter
         * Microsoft.NET.Test.Sdk
         */
        [TestInitialize]
        public void SetUp()
        {
            _primeService = new PrimeService();
        }

        [TestMethod]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = _primeService.IsPrime(1);

            Assert.IsFalse(result, "1 should not be prime");
        }

        [TestMethod]
        public void IsPrime_InputIs3_ReturnTrue()
        {
            var result = _primeService.IsPrime(3);

            Assert.IsTrue(result, "3 should be prime");
        }
    }
}
