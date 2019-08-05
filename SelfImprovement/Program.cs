using Autofac;
using System;

namespace SelfImprovement
{
    class Program
    {
        static void Main()
        {
            //App should take transactions from the file named transactions.txt with the following format:
            //Date | merchantName | amount
            //transactions.txt will always contain transactions ordered by date ASC
            /*----------------------------------*/
            //App should calculate fees per transaction
            /*----------------------------------*/
            //App should output result to console with the following format:
            //Date | merchantName | amount
            //Fee amount should be formatted: "25.00"
            //Date should be formatted: "YYYY-MM-DD"

            //Done
            //1. merchants to be charged Transaction Percentage Fee (1% of transaction amount)
            //Done
            //2. TELIA merchant to get Transaction Fee Percentage Discount (10% discount for transaction)
            //Done
            //3. CIRCLE_K merchant to get Transaction Fee Percentage Discount (20% discount for transaction)
            //Done
            //4. charge merchants Invoice Fixed Fee (29 DKK) every month
            //Done
            //5. Invoice Fee should be included in the fee for first transaction of the month
            //If there aren't any transactions that month, Merchant should not be charged Invoice Fee
            //If transaction fee is 0 after applying discounts, InvoiceFee should not be added <--Kaip gali but 0? (discount 100%)...

            var container = ContainerConfig.Configure();

            using(var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();

                app.Run();
            }

            Console.ReadKey(true);
        }
    }
}
