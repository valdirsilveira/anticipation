using api.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;

namespace api.Models.ViewModel
{
    public class TransactionModel
    {
        [Display(Name = "Id")]
        [ValidateTransaction]
        public long Id { get; set; }
        [Display(Name = "Acquirer Confirmation")]
        public bool? AcquirerConfirmation { get; set; }
        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "The value must be greater than 1")]
        public int Installments { get; set; }
        [Display(Name = "Transfer Date")]
        public DateTime? TransferDate { get; set; }
        [Display(Name = "Transaction Amount"), JsonRequired, JsonCurrency]
        public decimal TransactionAmount { get; set; }
        [Display(Name = "Transfer Amount"), JsonCurrency]
        public decimal? TransferAmount { get; set; }
    }
}
