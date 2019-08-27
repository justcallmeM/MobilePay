using System;
using System.Collections.Generic;

namespace Library.Utilities
{
    public interface IFees
    {
        List<decimal> AmountsAfterPercentageFee { get; set; }
        List<decimal> AmountsAfterInvoiceFee { get; set; }
        void CalculateOnePercentFee(List<decimal> amounts);
        void InvoiceFee(List<string> merchantNames, List<DateTime> dates, List<decimal> amountsAfterDiscount, List<UniqueEntry> uniqueEntries);
    }
}