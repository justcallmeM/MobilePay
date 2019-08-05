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

            _fees.CalculateOnePercentFee(_processedData.amount);

            _discounts.ApplyDiscounts(_fees.amountAfterPercentageFee, _processedData.merchantName);

            _fees.InvoiceFee(_processedData.merchantName, _processedData.date, _discounts.amountAfterDiscount, _processedData.uniqueEntries);

            for(int i = 0; i < _discounts.amountAfterDiscount.Count; i++)
            {
                Console.WriteLine("{0:MM/dd/yyyy}" + " " + _processedData.merchantName[i] + " {1:00.00}", _processedData.date[i], _discounts.amountAfterDiscount[i]);
            }
        }
    }
}
