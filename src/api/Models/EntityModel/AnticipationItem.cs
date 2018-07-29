using System;

namespace api.Models.EntityModel
{
    public class AnticipationItem
    {
        public long Id { get; set; }
        public long AnticipationId { get; set; }
        public Anticipation Anticipation { get; set; }
    }
}
