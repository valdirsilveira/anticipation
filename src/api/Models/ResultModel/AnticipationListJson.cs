using api.Extensions;
using api.Models.EntityModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models.ResultModel
{
    public class AnticipationListJson : IActionResult
    {
        public AnticipationListJson() { }

        public AnticipationListJson(IEnumerable<Anticipation> anticipations, long count, decimal periodAnticipationAmount)
        {
            Anticipations = anticipations.Select(anticipation => new AnticipationJson(anticipation)).ToList();
            Count = count;
            PeriodAnticipationAmount = periodAnticipationAmount.ToCurrency();
        }

        public long Count { get; set; }
        public IEnumerable<AnticipationJson> Anticipations { get; set; }
        public decimal PeriodAnticipationAmount { get; set; }

        public Task ExecuteResultAsync(ActionContext context)
        {
            return new JsonResult(this).ExecuteResultAsync(context);
        }
    }
}
