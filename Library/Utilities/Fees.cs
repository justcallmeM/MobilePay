using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Utilities
{
    public class Fees : IFees
    {
        public List<decimal> AmountsAfterPercentageFee { get; set; } = new List<decimal>();
        public List<decimal> AmountsAfterInvoiceFee { get; set; } = new List<decimal>();

        public void CalculateOnePercentFee(decimal amount)
        {
            AmountsAfterPercentageFee.Add(amount / 100);
        }

        public void InvoiceFee(string merchantName, DateTime date, decimal amountAfterDiscount, List<UniqueEntry> uniqueEntries)
        {
            foreach (var entry in uniqueEntries)
            {
                if(date == entry.Date && merchantName == entry.MerchantName)
                {
                    amountAfterDiscount += 29;
                }
            }
        }
    }
}
