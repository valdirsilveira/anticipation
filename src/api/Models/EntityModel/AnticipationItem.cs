using System;

namespace api.Models.EntityModel
{
    public class AnticipationItem
    {
        public long Id { get; set; }
        public long AnticipationId { get; set; }
        public long TransactionId { get; set; }
        public Anticipation Anticipation { get; set; }
        public Transaction Transaction { get; set; }
    }
}
