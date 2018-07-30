using api.Enums;
using api.Extensions;
using api.Infrastructure;
using api.Models.EntityModel;
using api.Models.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace api.Models.ServiceModel
{
    public class AnticipationProcessing
    {
        private const decimal AmountTransactionFee = (decimal) 0.9;

        private ApiDbContext _dbContext;

        public AnticipationProcessing(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Anticipation Anticipation { get; private set; }

        public async Task<bool> StartAnalysis(AnticipationModel model)
        {
            Anticipation = await _dbContext.Anticipations
                 .WhereId(model.Id)
                 .SingleOrDefaultAsync();

            Anticipation.AnticipationStatusId = (int)AnticipationStatusEnum.Analyzing;

            _dbContext.Update(Anticipation);

            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> Process(RequestAnticipationModel model)
        {
            Anticipation = model.Map();

            var transferAmount = (decimal) 0.0;

            foreach (var item in model.Transactions)
            {
                transferAmount += item.TransactionAmount.CalculateTransactionFees(item.Installments);

                Anticipation.AnticipationItems.Add(new AnticipationItem {
                     AnticipationId = Anticipation.Id,
                     TransactionId = item.Id
                });
            }

            Anticipation.TransferAmount =  transferAmount - AmountTransactionFee;

            _dbContext.Add(Anticipation);

            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
