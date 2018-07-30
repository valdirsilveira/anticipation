using api.Extensions;
using System;
using System.Linq;

namespace api.Models.EntityModel
{
    public static class TransactionQuery
    {
        #region WhereAvailableAnticipation
        public static IQueryable<Transaction> WhereAvailableAnticipation(this IQueryable<Transaction> transactions)
        {
            return transactions.Where(transaction =>
                transaction.AcquirerConfirmation == true
                && transaction.TransferDate == null
                && transaction.TransferAmount == null)
                .Select(t => new Transaction
                {
                    Id = t.Id,
                    AcquirerConfirmation = t.AcquirerConfirmation,
                    CreatedAt = t.CreatedAt,
                    Installments = t.Installments,
                    TransferDate = t.TransferDate,
                    TransactionAmount = t.TransactionAmount,
                    TransferAmount = t.TransactionAmount.CalculateTransactionFees(t.Installments)
                });
        }
        #endregion

        #region OrderByDescendingCreatedAt
        public static IQueryable<Transaction> OrderByDescendingCreatedAt(this IQueryable<Transaction> transactions)
        {
            return transactions.OrderByDescending(transaction => transaction.CreatedAt);
        }
        #endregion
        
        #region WhereDateFrom
        public static IQueryable<Transaction> WhereDateFrom(this IQueryable<Transaction> transactions, DateTime startDate)
        {
            return transactions.Where(transaction => transaction.CreatedAt.Date >= startDate.Date);
        }
        #endregion
        
        #region WhereDateUntil
        public static IQueryable<Transaction> WhereDateUntil(this IQueryable<Transaction> transactions, DateTime endDate)
        {
            return transactions.Where(transaction => transaction.CreatedAt.Date <= endDate.Date);
        }
        #endregion

        #region WhereId
        public static IQueryable<Transaction> WhereId(this IQueryable<Transaction> transactions, long transactionId)
        {
            return transactions.Where(transaction => transaction.Id == transactionId);
        }
        #endregion
    }
}
