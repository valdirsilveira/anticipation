using System;

namespace api.Models.ViewModel
{
    public class TransactionModel
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
