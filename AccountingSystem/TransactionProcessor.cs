using AccountingSystem.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AccountingSystem
{
    public class TransactionProcessor
    {
        public TransactionProcessor()
        {

        }

        /// <summary>
        /// Process transaction tally
        /// </summary>
        public void Process(List<Customer> customers)
        {
            try
            {
                var transactionDetails = GetTransationDetails();
                PerformTallyOperation(customers);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Message: {ex.Message}\nInnerException:{ex.InnerException}\nStackTrace:{ex.StackTrace}");
                throw new Exception($"Error in processing transaction tally");
            }
        }

        private void PerformTallyOperation(List<Customer> customers)
        {
            throw new NotImplementedException();
        }

        static List<TransactionDetails> GetTransationDetails() 
        {
            // our logic to read and create transaction detail dto 
            return new List<TransactionDetails>();
        }
    }
}
