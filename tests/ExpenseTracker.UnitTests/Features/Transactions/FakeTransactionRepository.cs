using ExpenseTracker.Application.Interfaces;
using ExpenseTracker.Domain.Entities;

namespace ExpenseTracker.UnitTests.Features.Transactions
{
    public class FakeTransactionRepository : ITransactionRepository
    {
        public List<Transaction> Transactions { get; } = [];
        public Task AddAsync(Transaction transaction)
        {
            Transactions.Add(transaction);
            return Task.CompletedTask;
        }

        public Task<IReadOnlyList<Transaction>> GetAllAsync()
        {
            return Task.FromResult<IReadOnlyList<Transaction>>(Transactions);
        }

        public Task<Transaction?> GetByIdAsync(Guid id)
        {
            var transaction =
            Transactions.FirstOrDefault(
                x => x.Id == id);

            return Task.FromResult(transaction);
        }
    }
}
