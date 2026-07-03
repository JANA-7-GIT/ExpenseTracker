using ExpenseTracker.Domain.Enums;

namespace ExpenseTracker.Application.Features.Transactions
{
    public class AddTransactionRequest
    {
        public decimal Amount { get; set; }
        public TransactionType Type { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Category { get; set; } = string.Empty;
        public string? Notes { get; set; }

    }
}
