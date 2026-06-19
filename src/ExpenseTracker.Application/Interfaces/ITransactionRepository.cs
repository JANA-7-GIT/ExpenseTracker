using ExpenseTracker.Domain.Entities;

namespace ExpenseTracker.Application.Interfaces
{
    public interface ITransactionRepository
    {
        /// <summary>
        /// Stores a transaction in the underlying data source.
        /// </summary>
        /// <param name="transaction"> The transaction to save. </param>
        Task AddAsync(Transaction transaction);

        /// <summary>
        /// Retrieves a transaction by its unique identifier.
        /// </summary>
        /// <param name="id"> Unique Transaction ID </param>
        /// <returns> The matching transaction if found; otherwise null. </returns>
        Task<Transaction?> GetByIdAsync(Guid id);

        /// <summary>
        /// Retrieves all transactions.
        /// </summary>
        /// <returns> A read-only collection of transactions. </returns>
        Task<IReadOnlyList<Transaction>> GetAllAsync();
    }
}
