using System;

namespace AccountingSystem.Models
{
    public enum TransactType
    {
        Debit,
        Credit
    }
    public class TransactionDetails
    {
        public int Amount { get; set; }
        public TransactType TransactionType { get; set; }
        public DateTime TransactDate { get; set; }
    }
}
