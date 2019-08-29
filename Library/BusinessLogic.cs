using Library.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class BusinessLogic : IBusinessLogic
    {
        IProcessedData _processedData;
        IFees _fees;
        IDiscounts _discounts;

        public BusinessLogic(IProcessedData processedData, IFees fees, IDiscounts discounts)
        {
            _processedData = processedData;
            _fees = fees;
            _discounts = discounts;
        }
        public void OutputResults()
        {
            _processedData.ProcessingData();

            _processedData.FindingUniqueCombinations();

            _fees.CalculateOnePercentFee(_processedData.Amounts);

            _discounts.ApplyDiscounts(_fees.AmountsAfterPercentageFee, _processedData.MerchantNames);

            _fees.InvoiceFee(_processedData.MerchantNames, _processedData.Dates, _discounts.AmountsAfterDiscount, _processedData.UniqueEntries);

            for(int i = 0; i < _discounts.AmountsAfterDiscount.Count; i++)
            {
                Console.WriteLine($"{_processedData.Dates[i]:MM/dd/yyyy} " + _processedData.MerchantNames[i] + $" {_discounts.AmountsAfterDiscount[i]:00.00}");
            }
        }
    }
}
