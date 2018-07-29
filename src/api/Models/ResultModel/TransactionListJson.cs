using api.Models.EntityModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace api.Models.ResultModel
{
    public class TransactionListJson : IActionResult
    {
        public TransactionListJson() { }

        public TransactionListJson(IEnumerable<Transaction> transactions, long count, decimal periodTransactionAmount)
        {
            Transactions = transactions.Select(transaction => new TransactionJson(transaction)).ToList();
            Count = count;
            PeriodTransactionAmount = periodTransactionAmount;
        }

        public long Count { get; set; }
        public IEnumerable<TransactionJson> Transactions { get; set; }
        public decimal PeriodTransactionAmount { get; set; }

        public Task ExecuteResultAsync(ActionContext context)
        {
            return new JsonResult(this).ExecuteResultAsync(context);
        }
    }
}
