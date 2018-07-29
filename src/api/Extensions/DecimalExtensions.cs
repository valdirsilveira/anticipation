using System;

namespace api.Extensions
{
    public static class DecimalExtensions
    {
        public static decimal ToCurrency(this decimal amount)
        {
            return Math.Round(amount, 2);
        }
    }
}
