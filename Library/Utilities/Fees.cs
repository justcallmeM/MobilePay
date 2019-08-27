using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Utilities
{
    public class Fees : IFees
    {
        public List<decimal> AmountsAfterPercentageFee { get; set; } = new List<decimal>();
        public List<decimal> AmountsAfterInvoiceFee { get; set; } = new List<decimal>();

        public void CalculateOnePercentFee(List<decimal> amounts)
        {
            foreach (decimal value in amounts)
            {
                AmountsAfterPercentageFee.Add(value / 100);
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
