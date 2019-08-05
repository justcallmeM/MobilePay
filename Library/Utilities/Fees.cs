using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Utilities
{
    public class Fees : IFees
    {
        public List<decimal> amountAfterPercentageFee { get; set; } = new List<decimal>();
        public List<decimal> amountAfterInvoiceFee { get; set; } = new List<decimal>();

        public void CalculateOnePercentFee(List<decimal> amount)
        {
            foreach (decimal value in amount)
            {
                amountAfterPercentageFee.Add(value / 100);
            }
        }

        public void InvoiceFee(List<string> merchantNames, List<DateTime> dates, List<decimal> amountsAfterDiscount, List<UniqueEntry> uniqueEntries)
        {
            for(int i=0; i < merchantNames.Count; i++)
            {
                foreach (var entry in uniqueEntries)
                {
                    if(dates[i] == entry.date && merchantNames[i] == entry.merchantName)
                    {
                        amountsAfterDiscount[i] += 29;
                    }
                }
            }
        }
    }
}
