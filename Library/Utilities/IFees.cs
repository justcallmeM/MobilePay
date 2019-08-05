using System;
using System.Collections.Generic;

namespace Library.Utilities
{
    public interface IFees
    {
        List<decimal> amountAfterPercentageFee { get; set; }
        List<decimal> amountAfterInvoiceFee { get; set; }
        void CalculateOnePercentFee(List<decimal> amount);
        void InvoiceFee(List<string> merchantName, List<DateTime> date, List<decimal> amountAfterDiscount, List<UniqueEntry> uniqueEntries);
    }
}