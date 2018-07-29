using System;
using System.Collections.Generic;

namespace api.Models.EntityModel
{
    public class Anticipation
    {
        public long Id { get; set; }
        public DateTime? AnalyzeDate { get; set; }
        public long AnticipationStatusId { get; set; }
        public bool? AnalyzeResult { get; set; }
        public AnticipationStatus AnticipationStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal RequestedAmount { get; set; }
        public decimal TransferAmount { get; set; }

        public ICollection<AnticipationItem> AnticipationItems { get; set; }
    }
}
