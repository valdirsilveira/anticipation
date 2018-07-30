using api.Models.EntityModel;
using api.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;

namespace api.Models.ViewModel
{
    public class AnticipationModel
    {
        [Display(Name = "Id")]
        [ValidateAnticipation]
        public long Id { get; set; }
        [Display(Name = "Analyze Date")]
        public DateTime? AnalyzeDate { get; set; }
        [Display(Name = "Anticipation Status")]
        public long AnticipationStatusId { get; set; }
        [Display(Name = "Analyze Result")]
        public bool? AnalyzeResult { get; set; }
        [Display(Name = "Created At"), JsonRequired]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "Requested Amount"), JsonRequired, JsonCurrency]
        public decimal RequestedAmount { get; set; }
        [Display(Name = "Transfer Amount"), JsonRequired, JsonCurrency]
        public decimal TransferAmount { get; set; }
    }
}
