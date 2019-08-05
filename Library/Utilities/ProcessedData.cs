using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Library.Utilities
{
    public class ProcessedData : IProcessedData
    {
        public List<DateTime> date { get; set; } = new List<DateTime>();
        public List<string> merchantName { get; set; } = new List<string>();
        public List<decimal> amount { get; set; } = new List<decimal>();
        private List<string> transactions { get; set; } = new List<string>();
        public List<UniqueEntry> uniqueEntries { get; set; } = new List<UniqueEntry>();

        public void ProcessingData()
        {

            List<string[]> detailedTransactions = new List<string[]>();

            string filePath = @"C:\Users\mindaugas.pikelis\Desktop\SMELIO DEZE\MobilePay\data.txt";

            transactions = File.ReadAllLines(filePath).ToList();
            transactions.Sort();

            foreach (string line in transactions)
            {
                detailedTransactions.Add(line.Split(" "));
            }

            foreach(string[] line in detailedTransactions)
            {
                date.Add(DateTime.Parse(line[0]));
                merchantName.Add(line[1]);
                Decimal.TryParse(line[2], out decimal value);
                amount.Add(value);
            }
        }

        public void FindingUniqueCombinations()
        {
            for(int i=0; i<transactions.Count(); i++)
            {
                UniqueEntry uniqueEntry = new UniqueEntry();
                bool exists = false;

                uniqueEntries.Add(uniqueEntry);

                foreach(var entry in uniqueEntries)
                {
                    if(entry.merchantName == merchantName[i] && entry.month == date[i].Month.ToString())
                    {
                        exists = true;
                        break;
                    }
                }

                if (exists == false)
                {
                    uniqueEntries[i].month = date[i].Month.ToString();
                    uniqueEntries[i].date = date[i];
                    uniqueEntries[i].merchantName = merchantName[i];
                }
            }
        }
    }

    public class UniqueEntry
    {
        public string merchantName { get; set; }
        public DateTime date { get; set; }
        public string month { get; set; }
    }
}
