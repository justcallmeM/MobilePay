using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Utilities
{
    public class Discounts : IDiscounts
    {
        public List<decimal> AmountsAfterDiscount { get; set; } = new List<decimal>();
        public void ApplyDiscounts(decimal amountAfterPercentageFee, string merchantName)
        {
            int counter = 0;
            decimal discount = 0;

            switch (merchantName)
            {
                case "TELIA":
                    discount = 10m;
                    break;
                case "CIRCLE_K":
                    discount = 20m;
                    break;
                default:
                    discount = 0m;
                    break;
            }

            AmountsAfterDiscount.Add(amountAfterPercentageFee - discount / 100);

            counter++;
        }
    }
}
