using api.Enums;
using api.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace api.Models.ViewModel
{
    public class RequestAnticipationModel
    {
        public List<TransactionModel> Transactions { get; set; }

        public Anticipation Map() => new Anticipation
        {
            AnticipationStatusId = (int) AnticipationStatusEnum.Waiting,
            CreatedAt = DateTime.Now,
            RequestedAmount = Transactions.Sum(transaction => transaction.TransactionAmount)
        };
    }
}
