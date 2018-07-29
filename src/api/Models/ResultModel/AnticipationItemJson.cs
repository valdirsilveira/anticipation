using api.Extensions;
using api.Models.EntityModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace api.Models.ResultModel
{
    public class AnticipationItemJson : IActionResult
    {
        public AnticipationItemJson(AnticipationItem anticipationItem)
        {
            Id = anticipationItem.Id;
            AnticipationId = anticipationItem.AnticipationId;
            TransactionId = anticipationItem.TransactionId;            
            Anticipation = anticipationItem.Anticipation;
            Transaction = anticipationItem.Transaction;
        }

        public long Id { get; set; }
        public long AnticipationId { get; set; }
        public long TransactionId { get; set; }
        public Anticipation Anticipation { get; set; }
        public Transaction Transaction { get; set; }

        public Task ExecuteResultAsync(ActionContext context)
        {
            return new JsonResult(this).ExecuteResultAsync(context);
        }
    }
}
