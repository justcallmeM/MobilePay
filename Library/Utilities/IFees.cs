using System;
using System.Collections.Generic;

namespace Library.Utilities
{
    public interface IFees
    {
        List<decimal> AmountsAfterPercentageFee { get; set; }
        List<decimal> AmountsAfterInvoiceFee { get; set; }
        void CalculateOnePercentFee(decimal amount);
        void InvoiceFee(string merchantName, DateTime date, decimal amountAfterDiscount, List<UniqueEntry> uniqueEntries);
    }
}