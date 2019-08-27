using System;
using System.Collections.Generic;

namespace Library.Utilities
{
    public interface IProcessedData
    {
        void ProcessingData();
        void FindingUniqueCombinations();
        List<DateTime> Dates { get; set; }
        List<string> MerchantNames { get; set; }
        List<decimal> Amounts { get; set; }
        List<UniqueEntry> UniqueEntries { get; set; }
    }
}