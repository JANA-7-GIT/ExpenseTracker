using ExpenseTracker.Domain.Enums;
using ExpenseTracker.Domain.Exceptions;

namespace ExpenseTracker.Domain.Entities
{
    public class Transaction
    {
        public Guid Id { get; private set; }
        public decimal Amount { get; private set; }
        public TransactionType TransactionType { get; private set; }
        public string Category { get; private set; }
        public string? Notes { get; private set; }
        public DateTime TransactionDate { get; private set; }

        public Transaction(decimal amount, TransactionType transactionType, string category, DateTime transactionDate, string? notes = null)
        {
            ValidateAmount(amount);
            ValidateCategory(category);

            Id = Guid.NewGuid();
            Amount = amount;
            TransactionType = transactionType;
            Category = category;
            Notes = notes;
            TransactionDate = transactionDate;
        }

        public static void ValidateAmount(decimal amount)
        {
            if(amount <= 0)
            {
                throw new DomainException("Transaction amount must be greater than zero!");
            }
        }

        public static void ValidateCategory(string category)
        {
            if (string.IsNullOrWhiteSpace(category)) {
                throw new DomainException("Category is required.");
            }
        }
    }
}
