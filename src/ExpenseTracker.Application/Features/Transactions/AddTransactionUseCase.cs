using ExpenseTracker.Application.Interfaces;
using ExpenseTracker.Domain.Entities;

namespace ExpenseTracker.Application.Features.Transactions
{
    public class AddTransactionUseCase
    {
        private readonly ITransactionRepository _transactionRepository;
        public AddTransactionUseCase(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public async Task ExecuteAsync(AddTransactionRequest request)
        {
            var transaction = new Transaction(
                request.Amount,
                request.Type,
                request.Category,
                request.TransactionDate,
                request.Notes);

            await _transactionRepository.AddAsync(transaction);
        }
    }
}
