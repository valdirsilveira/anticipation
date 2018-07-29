using System;
using System.ComponentModel.DataAnnotations;

namespace api.Models.ViewModel
{
    public class TransactionModel
    {
        public long Id { get; set; }
        public bool? AcquirerConfirmation { get; set; }
        public DateTime CreatedAt { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "The value must be greater than 1")]
        public int Installments { get; set; }
        public DateTime? TransferDate { get; set; }
        public decimal TransactionAmount { get; set; }
        public decimal? TransferAmount { get; set; }
    }
}
