using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Domain.Enums;
using ExpenseTracker.Domain.Exceptions;

namespace ExpenseTracker.UnitTests.Entities
{
    public class TransactionTests
    {
        [Fact]
        public void Constructor_Should_Create_Transaction_When_Data_IsValid()
        {
            var transaction = new Transaction(
                100,
                TransactionType.Expense,
                "Food",
                DateTime.Now);

            Assert.Equal(100, transaction.Amount);
            Assert.Equal("Food", transaction.Category);
            Assert.Equal(TransactionType.Expense, transaction.TransactionType);

        }

        [Fact]
        public void Constructor_Should_Throw_When_Amount_Is_Not_Valid()
        {
            Assert.Throws<DomainException>(() =>
                new Transaction(
                    0,
                    TransactionType.Expense,
                    "Food",
                    DateTime.Now));
        }
    }
}
