using System.Collections.Generic;

namespace Library.Utilities
{
    public interface IDiscounts
    {
        List<decimal> AmountsAfterDiscount { get; set; }
        void ApplyDiscounts(decimal amountAfterPercentageFee, string merchantName);
    }
}