using api.Extensions;
using System;
using Xunit;

namespace Unit.Extensions
{
    public class DecimalExtensionsTest
    {
        [Fact]
        public void CalculateTransactionFeesTest()
        {
            var transactionAmount = (decimal) 200;
            var installments = 1;
            var expectedResult = (decimal)192.40;
            var transferAmount = transactionAmount.CalculateTransactionFees(installments);
            Assert.Equal(transferAmount, expectedResult);
        }
    }
}
