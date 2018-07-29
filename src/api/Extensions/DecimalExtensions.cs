using System;

namespace api.Extensions
{
    public static class DecimalExtensions
    {
        private const double TransactionFee = 3.8;

        public static decimal ToCurrency(this decimal amount)
        {
            return Math.Round(amount, 2);
        }

        public static decimal CalculateTransactionFees(this decimal transactionAmount, int installments)
        {
            return transactionAmount - ((((decimal)DecimalExtensions.TransactionFee / 100) * (transactionAmount / installments)) * installments);
        }
    }
}
