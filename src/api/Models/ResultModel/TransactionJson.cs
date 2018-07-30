using api.Extensions;
using api.Models.EntityModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace api.Models.ResultModel
{
    public class TransactionJson : IActionResult
    {
        public TransactionJson() { }

        public TransactionJson(Transaction transaction)
        {
            Id = transaction.Id;
            AcquirerConfirmation = transaction.AcquirerConfirmation;
            CreatedAt = transaction.CreatedAt;
            Installments = transaction.Installments;
            TransferDate = transaction.TransferDate;
            TransactionAmount = transaction.TransactionAmount.ToCurrency();
            TransferAmount = (transaction.TransferAmount != null) ?
                ((decimal)transaction.TransferAmount).ToCurrency() : (decimal) 0.0;                
        }

        public long Id { get; set; }
        public bool? AcquirerConfirmation { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Installments { get; set; }
        public DateTime? TransferDate { get; set; }
        public decimal TransactionAmount { get; set; }
        public decimal? TransferAmount { get; set; }

        public Task ExecuteResultAsync(ActionContext context)
        {
            return new JsonResult(this).ExecuteResultAsync(context);
        }
    }
}
