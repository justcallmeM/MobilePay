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

            for(int i = 0; i < _processedData.Transactions.Count; i++)
            {
                _processedData.FindingUniqueCombinations(i);

                _fees.CalculateOnePercentFee(_processedData.Amounts[i]);

                _discounts.ApplyDiscounts(_fees.AmountsAfterPercentageFee[i], _processedData.MerchantNames[i]);

                _fees.InvoiceFee(_processedData.MerchantNames[i], _processedData.Dates[i], _discounts.AmountsAfterDiscount[i], _processedData.UniqueEntries);
            }


            for(int i = 0; i < _discounts.AmountsAfterDiscount.Count; i++)
            {
                Console.WriteLine($"{_processedData.Dates[i]:MM/dd/yyyy} " + _processedData.MerchantNames[i] + $" {_discounts.AmountsAfterDiscount[i]:00.00}");
            }
        }
    }
}
