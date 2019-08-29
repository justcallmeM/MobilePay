using System;
using System.Collections.Generic;

namespace Library.Utilities
{
    public interface IProcessedData
    {
        void ProcessingData();
        void FindingUniqueCombinations(int counter);
        List<DateTime> Dates { get; set; }
        List<string> MerchantNames { get; set; }
        List<decimal> Amounts { get; set; }
        List<string> Transactions { get; set; } 
        List<UniqueEntry> UniqueEntries { get; set; }
    }
}