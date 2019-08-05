using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Utilities
{
    public class Discounts : IDiscounts
    {
        public List<decimal> amountAfterDiscount { get; set; } = new List<decimal>();
        public void ApplyDiscounts(List<decimal> amountAfterPercentageFee, List<string> merchantNames)
        {
            int counter = 0;
            decimal discount = 0;

            foreach (string name in merchantNames)
            {
                switch (name)
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

                amountAfterDiscount.Add(amountAfterPercentageFee[counter] - discount / 100);

                counter++;
            }
        }
    }
}
