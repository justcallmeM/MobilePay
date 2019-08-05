using System.Collections.Generic;

namespace Library.Utilities
{
    public interface IDiscounts
    {
        List<decimal> amountAfterDiscount { get; set; }
        void ApplyDiscounts(List<decimal> finalFee, List<string> merchantNames);
    }
}