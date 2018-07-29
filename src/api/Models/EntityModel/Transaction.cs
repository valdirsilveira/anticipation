using System;

namespace api.Models.EntityModel
{
    public class Transaction
    {
        public long Id { get; set; }
        public bool? AcquirerConfirmation { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Installments { get; set; }
        public DateTime? TransferDate { get; set; }        
        public decimal TransactionAmount { get; set; }
        public decimal? TransferAmount { get; set; }        
    }
}
