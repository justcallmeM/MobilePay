using System;
using System.Collections.Generic;

namespace Library.Utilities
{
    public interface IProcessedData
    {
        void ProcessingData();
        void FindingUniqueCombinations();
        List<DateTime> date { get; set; }
        List<string> merchantName { get; set; }
        List<decimal> amount { get; set; }
        List<UniqueEntry> uniqueEntries { get; set; }
    }
}