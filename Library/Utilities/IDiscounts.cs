using System.Collections.Generic;

namespace Library.Utilities
{
    public interface IDiscounts
    {
        List<decimal> AmountsAfterDiscount { get; set; }
        void ApplyDiscounts(List<decimal> amountsAfterPercentageFee, List<string> merchantNames);
    }
}