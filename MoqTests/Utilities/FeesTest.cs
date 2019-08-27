using Autofac.Extras.Moq;
using Library.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Xunit;

namespace MoqTests
{
    public class FeesTest
    {
        Fees fees = new Fees();

        [Fact]
        public void CalculateOnePercentFee_basicDivision()
        {
            List<decimal> amounts = new List<decimal>() { 100m, 200m, 300m , 400m, 500m};
            List<decimal> expected = new List<decimal>() { 1m, 2m, 3m, 4m, 5m};

            fees.CalculateOnePercentFee(amounts);

            CollectionAssert.AreEqual(expected, fees.amountAfterPercentageFee);
        }
    }
}
