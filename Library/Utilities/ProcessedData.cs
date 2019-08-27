﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Library.Utilities
{
    public class ProcessedData : IProcessedData
    {
        public List<DateTime> Dates { get; set; } = new List<DateTime>();
        public List<string> MerchantNames { get; set; } = new List<string>();
        public List<decimal> Amounts { get; set; } = new List<decimal>();
        private List<string> Transactions { get; set; } = new List<string>();
        public List<UniqueEntry> UniqueEntries { get; set; } = new List<UniqueEntry>();

        public void ProcessingData()
        {

            List<string[]> detailedTransactions = new List<string[]>();

            string filePath = @"C:\Users\mindaugas.pikelis\Desktop\SMELIO DEZE\MobilePay\data.txt";

            Transactions = File.ReadAllLines(filePath).ToList();
            Transactions.Sort();

            foreach (string line in Transactions)
            {
                detailedTransactions.Add(line.Split(" "));
            }

            foreach(string[] line in detailedTransactions)
            {
                Dates.Add(DateTime.Parse(line[0]));
                MerchantNames.Add(line[1]);
                Decimal.TryParse(line[2], out decimal value);
                Amounts.Add(value);
            }
        }

        public void FindingUniqueCombinations()
        {
            for(int i=0; i<Transactions.Count(); i++)
            {
                UniqueEntry uniqueEntry = new UniqueEntry();
                bool exists = false;

                UniqueEntries.Add(uniqueEntry);

                foreach(var entry in UniqueEntries)
                {
                    if(entry.MerchantName == MerchantNames[i] && entry.Month == Dates[i].Month.ToString())
                    {
                        exists = true;
                        break;
                    }
                }

                if (exists == false)
                {
                    UniqueEntries[i].Month = Dates[i].Month.ToString();
                    UniqueEntries[i].Date = Dates[i];
                    UniqueEntries[i].MerchantName = MerchantNames[i];
                }
            }
        }
    }

    public class UniqueEntry
    {
        public string MerchantName { get; set; }
        public DateTime Date { get; set; }
        public string Month { get; set; }
    }
}
