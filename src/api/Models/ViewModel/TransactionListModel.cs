using System;

namespace api.Models.ViewModel
{
    public class TransactionListModel
    {
        public DateTime EndDate { get; set; }
        public int? Index { get; set; }
        public int? Length { get; set; }
        public DateTime StartDate { get; set; }
    }
}
