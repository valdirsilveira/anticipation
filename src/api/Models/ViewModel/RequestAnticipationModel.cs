using api.Enums;
using api.Models.EntityModel;
using api.Models.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace api.Models.ViewModel
{
    public class RequestAnticipationModel
    {
        [Display(Name = "List Transactions"), JsonRequired]
        public List<TransactionModel> Transactions { get; set; }

        public Anticipation Map() => new Anticipation
        {
            AnticipationStatusId = (int) AnticipationStatusEnum.Waiting,
            CreatedAt = DateTime.Now,
            RequestedAmount = Transactions.Sum(transaction => transaction.TransactionAmount)
        };
    }
}
