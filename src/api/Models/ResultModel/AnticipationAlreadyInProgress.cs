using api.Extensions;
using api.Models.EntityModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization;
using System.Threading.Tasks;
namespace api.Models.ResultModel
{
    public class AnticipationAlreadyInProgress : IActionResult
    {
        public AnticipationAlreadyInProgress(Anticipation anticipationInProgress)
        {
            AnticipationInProgress = anticipationInProgress;
            Message = "There is an anticipation in progress.";
        }

        public String Message { get; set; }
        public Anticipation AnticipationInProgress { get; set; }

        public Task ExecuteResultAsync(ActionContext context)
        {
            context.HttpContext.Response.StatusCode = (int) HttpStatusCode.Conflict;
            return new JsonResult(this).ExecuteResultAsync(context);
        }
    }
}
