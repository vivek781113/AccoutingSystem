using AccountingSystem.Models;
using System;
using System.Collections.Generic;

namespace AccountingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var invoiceProcessor = new InvoiceProcessor();
                List<Customer> customers = GetCustomerDetails();
                invoiceProcessor.GenerateInvoice(customers);

                var transactionProcessor = new TransactionProcessor();
                transactionProcessor.Process(customers);
            }
            catch (Exception)
            {

                throw;
            }

        }

        private static List<Customer> GetCustomerDetails()
        {
            throw new NotImplementedException();
        }
    }
}
