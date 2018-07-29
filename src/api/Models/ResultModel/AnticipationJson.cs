using api.Extensions;
using api.Models.EntityModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace api.Models.ResultModel
{
    public class AnticipationJson : IActionResult
    {
        public AnticipationJson(Anticipation anticipation)
        {
            Id = anticipation.Id;
            AnalyzeDate = anticipation.AnalyzeDate;
            AnticipationStatusId = anticipation.AnticipationStatusId;
            AnalyzeResult = anticipation.AnalyzeResult;
            CreatedAt = anticipation.CreatedAt;
            RequestedAmount = anticipation.RequestedAmount.ToCurrency();
            TransferAmount = (anticipation.TransferAmount).ToCurrency();
        }

        public long Id { get; set; }
        public DateTime? AnalyzeDate { get; set; }
        public long AnticipationStatusId { get; set; }
        public bool? AnalyzeResult { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal RequestedAmount { get; set; }
        public decimal TransferAmount { get; set; }
        
        public Task ExecuteResultAsync(ActionContext context)
        {
            return new JsonResult(this).ExecuteResultAsync(context);
        }
    }
}
