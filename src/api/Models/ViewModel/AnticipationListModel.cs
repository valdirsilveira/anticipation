using api.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;

namespace api.Models.ViewModel
{
    public class AnticipationListModel
    {
        [Display(Name = "End Date"), JsonRequired]
        public DateTime EndDate { get; set; }
        [Display(Name = "Index"), JsonRequired]
        public int Index { get; set; }
        [Display(Name = "Length"), JsonRequired]
        public int Length { get; set; }
        [Display(Name = "Start Date"), JsonRequired]
        public DateTime StartDate { get; set; }
    }
}
