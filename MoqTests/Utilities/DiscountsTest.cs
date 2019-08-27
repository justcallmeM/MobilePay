using Autofac.Extras.Moq;
using Library.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Xunit;

namespace MoqTests
{
    public class DiscountsTest
    {
        Discounts discounts = new Discounts();

        [Fact]
        public void ApplyDiscounts_swichChoosings()
        {
            //Arrange
            List<string> merchants = new List<string>() { "CIRCLE_K", "TELIA", "NETTO", "TELIA" };
            List<decimal> fee = new List<decimal>() { 1m, 2m, 1.5m, 0.5m };

            List<decimal> expected = new List<decimal>() { 0.8m, 1.9m, 1.5m, 0.4m };

            //Act
            discounts.ApplyDiscounts(fee, merchants);

            //Assert
            //Assert.Equal(expected, discounts.amountAfterDiscount);
            CollectionAssert.AreEqual(expected, discounts.amountAfterDiscount);
        }
    }
}
