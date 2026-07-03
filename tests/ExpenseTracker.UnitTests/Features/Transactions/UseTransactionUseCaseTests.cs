using ExpenseTracker.Application.Features.Transactions;
using ExpenseTracker.Domain.Enums;

namespace ExpenseTracker.UnitTests.Features.Transactions
{
    public class UseTransactionUseCaseTests
    {
        [Fact]
        public async Task ExecuteAsync_Should_add_Transaction()
        {
            var repository = new FakeTransactionRepository();

            var useCase = new AddTransactionUseCase(repository);

            var transactionRequest = new AddTransactionRequest
            {
                Amount = 100.0m,
                Type = TransactionType.Expense,
                TransactionDate = DateTime.UtcNow,
                Category = "Food",
                Notes = "Lunch at restaurant"
            };

            await useCase.ExecuteAsync(transactionRequest);

            Assert.Single(repository.Transactions);

            var transaction = repository.Transactions.First();

            Assert.Equal(100.0m, transaction.Amount);
            Assert.Equal(TransactionType.Expense, transaction.TransactionType);
            Assert.Equal("Food", transaction.Category);

        }
    }
}
